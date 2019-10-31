using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using Scraper.Shared;
using System.Web;
using HtmlAgilityPack;
using Houzz;
using Databox.Libs.Houzz;
using System.Net;
using Houzz.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace WheelsScraper
{
    public class Houzz : BaseScraper
    {
        public Houzz()
        {
            Name = "Houzz";
            Url = "https://www.houzz.com/";
            PageRetriever.Referer = Url;
            WareInfoList = new List<ExtWareInfo>();
            Wares.Clear();
            BrandItemType = 2;

            SpecialSettings = new ExtSettings();
            

        }

        private ExtSettings extSett
        {
            get
            {
                return (ExtSettings)Settings.SpecialSettings;
            }
        }

        public override Type[] GetTypesForXmlSerialization()
        {
            return new Type[] { typeof(ExtSettings) };
        }

        public override System.Windows.Forms.Control SettingsTab
        {
            get
            {
                var frm = new ucExtSettings();
                frm.Sett = Settings;
                return frm;
            }
        }

        public override WareInfo WareInfoType
        {
            get
            {
                return new ExtWareInfo();
            }
        }

        protected override bool Login()
        {
            return true;
        }

        protected override void RealStartProcess()
        {
            
            System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            countPages = 0;
            nextPage = false;
            count = 0;
            scanProduct.Clear();
            bool startProcess = false;
            foreach (var item in ucExtSettings.links)
            {
                if (item != null)
                {
                    startProcess = true;
                    lstProcessQueue.Add(new ProcessQueueItem { URL = item, ItemType = 40 });
                    StartOrPushPropertiesThread();

                }  
            }
            if (!startProcess)
            {
                lstProcessQueue.Add(new ProcessQueueItem { URL = Url, ItemType = 40 });
                StartOrPushPropertiesThread();
            }

        }

        int countPages;
        int count = 0;
        string activeUrl = string.Empty;
        bool nextPage = false;
        List<string> scanProduct = new List<string>();
        protected void ProcessFindLinks(ProcessQueueItem pqi)
        {
            if (cancel)
                return;
            try
            {
                var countLinks = pqi.URL.Split('\n');
                foreach (var item in countLinks)
                {
                    if (item.StartsWith("https://www.houzz.com/product/"))
                    {
                        lock (this)
                            lstProcessQueue.Add(new ProcessQueueItem { ItemType = 10, URL = item.Replace("\r", "") });
                    }
                    else if (item.StartsWith("https://www.houzz.com/products/"))
                    {
                        lock (this)
                            lstProcessQueue.Add(new ProcessQueueItem { ItemType = 50, URL = item.Replace("\r", "") });
                    }
                    else if (item.StartsWith("https://www.houzz.com/pro/"))
                    {
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        var html = PageRetriever.ReadFromServer(item.Replace("\r", ""));
                        var htmlDoc = new HtmlDocument();
                        htmlDoc.LoadHtml(html);
                        var allProductLink = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='brand-narrow brand-profile']/section/footer/a").AttributeOrNull("href");
                        if (allProductLink != null)
                        {
                            lock (this)
                                lstProcessQueue.Add(new ProcessQueueItem { ItemType = 50, URL = allProductLink });
                        }
                    }
                    else
                    {
                        MessagePrinter.PrintMessage("Incorrect link");
                    }
                }
            }
            catch (Exception ex) { }
            
            pqi.Processed = true;
            MessagePrinter.PrintMessage("Brands list processed");
            StartOrPushPropertiesThread();
        }
        protected void ProcessSearchProduct(ProcessQueueItem pqi)
        {
            if (cancel)
                return;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                MessagePrinter.PrintMessage("page of products " + pqi.URL);
                //pqi.URL = "https://www.houzz.com/products/artwork/art_subject_name--Portrait/height_4--5-to-9-Inches/width_4--Under-10-Inches";
                //pqi.URL = "https://www.houzz.com/products/artwork/manufacturer--artbycamille--canvasartusa";

                if (!nextPage)
                {
                    activeUrl = pqi.URL;
                }
                var html = PageRetriever.ReadFromServer(pqi.URL);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);


                //var findJson = htmlDoc.DocumentNode.SelectSingleNode(".//div[@class='container hz-br-container mbl']/div/div/div[2]/script").InnerTextOrNull();
                var findJson = htmlDoc.DocumentNode.SelectSingleNode(".//script[@id='hz-ctx']").InnerTextOrNull();
                if (findJson != null)
                {
                    var enumProducts = JsonConvert.DeserializeObject<JsonEnum>(findJson);
                    if (enumProducts.itemListElement == null || enumProducts.itemListElement.Length < 36)
                    {
                        Thread t = Thread.CurrentThread;
                        var name = t.Name;
                        Thread.Sleep(5000);

                        var htmlSecond = PageRetriever.ReadFromServer(pqi.URL);
                        var htmlDocSecond = new HtmlDocument();
                        htmlDoc.LoadHtml(htmlSecond);


                        findJson = htmlDoc.DocumentNode.SelectSingleNode(".//div[@class='container hz-br-container mbl']/div/div/div[2]/script").InnerTextOrNull();
                        enumProducts = JsonConvert.DeserializeObject<JsonEnum>(findJson);
                    }
                    

                    if (enumProducts != null)
                    {
                        foreach (var item in enumProducts.itemListElement)
                        {
                            //var productUrl = item.SelectSingleNode("./div/a").AttributeOrNull("href");
                            lock (this)
                                lstProcessQueue.Add(new ProcessQueueItem { ItemType = 10, URL = item.url });
                        }
                    }


                    //var errorPage = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='mbl text-bold header-5 text-bold']").InnerTextOrNull();
                    if (enumProducts.itemListElement.Count() > 0)
                    {
                        countPages = countPages + 36;
                        lock (this)
                            lstProcessQueue.Add(new ProcessQueueItem { ItemType = 50, URL = activeUrl + "/p/" + countPages });
                        nextPage = true;

                    }
                    else
                    {
                        countPages = 0;
                        nextPage = false;
                    }
                }
                else
                {
                    if (!pqi.DataFound)
                    {
                        Thread t = Thread.CurrentThread;
                        var name = t.Name;
                        Thread.Sleep(500);

                        lock (this)
                            lstProcessQueue.Add(new ProcessQueueItem { ItemType = 50, URL = pqi.URL , DataFound = true});
                        count++;
                    }
                    //else return;
                }
                
                
            }
            catch (Exception ex)
            {

                
            }




            pqi.Processed = true;
            MessagePrinter.PrintMessage("Brands list processed");
            StartOrPushPropertiesThread();
        }

        protected void ProcessProductListPage(ProcessQueueItem pqi)
        {
            if (cancel)
                return;

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            MessagePrinter.PrintMessage("Product processed " + pqi.URL);
            
            var html = PageRetriever.ReadFromServer(pqi.URL);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            ExtWareInfo wi = new ExtWareInfo();
            var prodJson = htmlDoc.DocumentNode.SelectSingleNode("//script[@id='hz-ctx']");
            string pJson = prodJson.InnerTextOrNull();


            if (pJson != null)

            {
                
                var responceInfo = JsonConvert.DeserializeObject<ResponsePoduct>(pJson);

                bool brandFound = false;
                var id = responceInfo.data.stores.data.ProductDataStore.data["currentSpaceId"].ToString();
                var productInfo = responceInfo.data.stores.data.ProductDataStore.data[id].ToObject<ProductID>();
                wi.ProductTitle = productInfo.title;
                wi.Description = productInfo.description;
                wi.PartNumber = productInfo.selectedVendorListing.productCode;
                wi.URL = pqi.URL;
                wi.ProductId = productInfo.productId;
                string speca = "Specification##";
                if (productInfo.productSpec.productSpecItems != null )
                {
                    try
                    {
                        var one = productInfo.productSpec.productSpecItems["1"].ToObject<One>();
                        string name = one.name;
                        string value = one.value;
                        if (name != null || value != null)
                        {
                            wi.Brand = value;
                        }
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }

                    }
                    catch (Exception err)
                    {
                        brandFound = true;
                    }

                    try
                    {
                        if (brandFound)
                        {
                            wi.Brand = "Houzz";
                        }
                        var two = productInfo.productSpec.productSpecItems["2"].ToObject<_2>();
                        string name = two.name;
                        string value = two.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var three = productInfo.productSpec.productSpecItems["3"].ToObject<_3>();
                        string name = three.name;
                        string value = three.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                        string[] sizeArray = value.Split('"');
                        if (sizeArray != null)
                        {
                            foreach (var item in sizeArray)
                            {
                                if (item.Contains("D"))
                                {
                                    wi.ItemLength = item.Replace("D", "").Replace("/", "").Replace("oz.", "").Replace("lb.", "").TrimStart().TrimEnd();
                                }
                                if (item.Contains("W"))
                                {
                                    wi.ItemWidth = item.Replace("W", "").Replace("/", "").Replace("oz.", "").Replace("lb.", "").TrimStart().TrimEnd();
                                }
                                if (item.Contains("H"))
                                {
                                    wi.ItemHeight = item.Replace("H", "").Replace("/", "").Replace("oz.", "").Replace("lb.", "").TrimStart().TrimEnd();
                                }
                                if (item.Contains("oz.") || item.Contains("oz") || item.Contains("lb.") || item.Contains("lb"))
                                {
                                    wi.ItemWeight = item.Replace("oz.", "").Replace("lb.", "").Replace("/", "").TrimStart().TrimEnd();
                                }

                            }
                            if (wi.ItemLength == null)
                            {
                                wi.ItemLength = "1";
                            }
                            if (wi.ItemWidth == null)
                            {
                                wi.ItemWidth = "1";
                            }
                            if (wi.ItemHeight == null)
                            {
                                wi.ItemHeight = "1";
                            }
                            if (wi.ItemWeight == null)
                            {
                                wi.ItemWeight = "1";
                            }


                        }

                    }
                    catch (Exception err)
                    {
                        if (wi.ItemLength == null)
                        {
                            wi.ItemLength = "1";
                        }
                        if (wi.ItemWidth == null)
                        {
                            wi.ItemWidth = "1";
                        }
                        if (wi.ItemHeight == null)
                        {
                            wi.ItemHeight = "1";
                        }
                        if (wi.ItemWeight == null)
                        {
                            wi.ItemWeight = "1";
                        }
                    }
                    try
                    {

                        var four = productInfo.productSpec.productSpecItems["4"].ToObject<_4>();
                        string name = four.name;
                        string value = four.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var five = productInfo.productSpec.productSpecItems["5"].ToObject<_5>();
                        string name = five.name;
                        string value = five.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var six = productInfo.productSpec.productSpecItems["6"].ToObject<_6>();
                        string name = six.name;
                        string value = six.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var seven = productInfo.productSpec.productSpecItems["7"].ToObject<_7>();
                        string name = seven.name;
                        string value = seven.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var eight = productInfo.productSpec.productSpecItems["8"].ToObject<_8>();
                        string name = eight.name;
                        string value = eight.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var nine = productInfo.productSpec.productSpecItems["9"].ToObject<_9>();
                        string name = nine.name;
                        string value = nine.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var ten = productInfo.productSpec.productSpecItems["10"].ToObject<_10>();
                        string name = ten.name;
                        string value = ten.value;
                        if (name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    try
                    {
                        var eleven = productInfo.productSpec.productSpecItems["11"].ToObject<_11_>();
                        string name = eleven.name;
                        string value = eleven.value;
                        if (name.ToLower().Contains("size") || name.ToLower().Contains("color") || name.ToLower().Contains("material") || name.ToLower().Contains("style"))
                        {
                            speca = speca + name + "~" + value + "^";
                        }
                    }
                    catch (Exception err) { }
                    if (speca != "Specification##")
                    {
                        wi.Specifications = speca.TrimEnd('^');
                    }
                    else wi.Specifications = "";


                }
                brandFound = false;
                wi.CostPrice = productInfo.selectedVendorListing.vendorListingPrices.price.amount;
                wi.MSRPItem = productInfo.selectedVendorListing.vendorListingPrices.msrp.amount;
                if (wi.MSRPItem.Contains("0"))
                {
                    wi.MSRPItem = wi.CostPrice;
                }
                    wi.WebPrice = wi.CostPrice;
                wi.JobberItem = wi.CostPrice;
                var categories = responceInfo.data.stores.data.ViewProductBreadcrumbStore.data.breadcrumbs.options;

                if (categories != null)
                {
                    if (categories.Length == 2)
                    {
                        if (categories[0].label.ToLower().Contains("all products"))
                        {
                            wi.MainCategory = categories[1].label;
                            

                        }
                        else
                        {
                            wi.MainCategory = categories[0].label;
                            wi.SubCategory = categories[1].label;

                        }
                    }
                    if (categories.Length == 3)
                    {
                        if (categories[0].label.ToLower().Contains("all products"))
                        {
                            wi.MainCategory = categories[1].label;
                            wi.SubCategory = categories[2].label;

                            
                        }
                        else
                        {
                            wi.MainCategory = categories[0].label;
                            wi.SubCategory = categories[1].label;
                            wi.SectionCategory = categories[3].label;

                        }
                    }
                    if (categories.Length == 4)
                    {
                        if (categories[0].label.ToLower().Contains("all products"))
                        {
                            wi.MainCategory = categories[1].label;
                            wi.SubCategory = categories[2].label;
                            wi.SectionCategory = categories[3].label;
                        }
                        else
                        {
                            wi.MainCategory = categories[0].label;
                            wi.SubCategory = categories[1].label;
                            wi.SectionCategory = categories[2].label;
                            wi.SectionCategory2 = categories[3].label;
                        }
                    }
                    if (categories.Length == 5)
                    {
                        if (categories[0].label.ToLower().Contains("all products"))
                        {
                            wi.MainCategory = categories[1].label;
                            wi.SubCategory = categories[2].label;
                            wi.SectionCategory = categories[3].label;
                            wi.SectionCategory2 = categories[4].label;
                        }
                        else
                        {
                            wi.MainCategory = categories[0].label;
                            wi.SubCategory = categories[1].label;
                            wi.SectionCategory = categories[2].label;
                            wi.SectionCategory2 = categories[3].label;
                            wi.SectionCategory3 = categories[4].label;
                        }
                    }
                    if (categories.Length == 6)
                    {
                        if (categories[0].label.ToLower().Contains("all products"))
                        {
                            wi.MainCategory = categories[1].label;
                            wi.SubCategory = categories[2].label;
                            wi.SectionCategory = categories[3].label;
                            wi.SectionCategory2 = categories[4].label;
                            wi.SectionCategory3 = categories[5].label;
                        }
                        else
                        {
                            wi.MainCategory = categories[0].label;
                            wi.SubCategory = categories[1].label;
                            wi.SectionCategory = categories[2].label;
                            wi.SectionCategory2 = categories[3].label;
                            wi.SectionCategory3 = categories[4].label;
                        }
                    }
                }


                if (!extSett.Option1)
                {
                    //var checkKey = scanProduct.Any(s => s.Contains(id));

                    
                    if (responceInfo.data.stores.data.ProductVariationsStore.data.Count > 0)
                    {
                        var options = responceInfo.data.stores.data.ProductVariationsStore.data[id].ToObject<ProductOptions>();
                        foreach (var item in options.variationProducts)
                        {
                            var key = item.Key;
                            var checkKey = scanProduct.Any(s => s.Contains(key));
                            if (!checkKey)
                            {
                                scanProduct.Add(key);
                                var url = item.Value["url"].ToString();

                                if (key != id)
                                {
                                    lock (this)
                                        lstProcessQueue.Add(new ProcessQueueItem { ItemType = 10, URL = url });
                                }
                            }
                        }

                            
                    }
                    
                }
            }

            try
            {
                var appImage = string.Empty;
                HtmlNodeCollection logBullet = htmlDoc.DocumentNode.SelectNodes("//div[@class='hzui-carousel  hzui-carousel--vertical hzui-carousel--animated hzui-carousel--masked-vertical']/div/div/div");
                if (logBullet != null)
                {
                    foreach (var item in logBullet)
                    {
                        var sliderImgUrl = item.SelectSingleNode("./img").AttributeOrNull("src");
                        string[] cutImage = sliderImgUrl.Split('_');
                        var imageUrl = cutImage[0].Replace("fimgs", "simgs") + "_9-3999/home-design.jpg";
                        appImage = appImage + imageUrl + ",";
                    }
                    wi.GeneralImage = appImage.TrimEnd(',');
                }
               else
                {
                    //var mainImage = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='zoom-pane product-zoom-pane']/div/img");
                    var mainImage = htmlDoc.DocumentNode.SelectSingleNode("//img[@class='view-product-image-print visible-print-block']").AttributeOrNull("src");
                    wi.GeneralImage = mainImage;
                }
            }
            catch (Exception ex) { }

            AddWareInfo(wi);
            OnItemLoaded(wi);

            pqi.Processed = true;
            MessagePrinter.PrintMessage("completed");
            StartOrPushPropertiesThread();
        }
        public List<Filter> GetListCategory()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                List<Filter> categoryArray = new List<Filter>();
                
                var html = PageRetriever.ReadFromServer("https://www.houzz.com/products");
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);


                var test = htmlDoc.DocumentNode.SelectSingleNode("//div[@class = 'sidebar-section']").OuterHtml;

                HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(".//div[@class = 'sidebar filter-tree collapsible']/div[2]/ul/li");
                if (nodes != null)
                {
                    foreach (var item in nodes)
                    {
                        var name = item.SelectSingleNode(".//a").InnerTextOrNull();
                        if (name.ToLower().Contains("all products"))
                        {
                            continue;
                        }

                        var link = item.SelectSingleNode(".//a").AttributeOrNull("href");
                        categoryArray.Add(new Filter() { Name = name, Link = link });

                    }
                }
                else
                {
                    MessagePrinter.PrintMessage("Lost connection https://www.houzz.com/products");
                }
                return categoryArray;
            }
            catch (Exception ex)
            {

                return null;
            }
           
        }
        public List<Filter> GetListSubCat(string nameLink)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                List<Filter> subCategoryArray = new List<Filter>();

                var html = PageRetriever.ReadFromServer(nameLink);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);


                var test = htmlDoc.DocumentNode.SelectSingleNode("//div[@class = 'sidebar-section']").OuterHtml;

                HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes(".//div[@class = 'sidebar filter-tree collapsible']/div[2]/ul/li");
                if (nodes != null)
                {
                    foreach (var item in nodes)
                    {
                        var name = item.SelectSingleNode(".//a").InnerTextOrNull();
                        var link = item.SelectSingleNode(".//a").AttributeOrNull("href");
                        if (name.ToLower().Contains("all products") || link == nameLink)
                        {
                            continue;
                        }

                        
                        subCategoryArray.Add(new Filter() { Name = name, Link = link });

                    }
                }
                else
                {
                    MessagePrinter.PrintMessage("Lost connection https://www.houzz.com/products");
                }
                return subCategoryArray;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public List<Filter> GetListFilters(string nameLink)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                List<Filter> subCategoryArray = new List<Filter>();
                
                var html = PageRetriever.ReadFromServer(nameLink);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);


                var jsonFilters = htmlDoc.DocumentNode.SelectSingleNode("//script[@id = 'hz-ctx']").InnerTextOrNull();


                if (jsonFilters != null)
                {
                    var responceInfo = JsonConvert.DeserializeObject<InterfaceFilter>(jsonFilters);
                    var test = "";
                    foreach (var item in responceInfo.data.stores.data.NavigationStore.data.filters)
                    {
                        Filter filters = new Filter();
                        if (item.header == "Category") continue;
                        filters.Name = item.header;
                        subCategoryArray.Add(filters);
                    }
                }

               
               
                return subCategoryArray;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public List<Filter> FindFilterByName(string nameLink, string filter)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                List<Filter> filtersUrl = new List<Filter>();

                var html = PageRetriever.ReadFromServer(nameLink);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);


                var jsonFilters = htmlDoc.DocumentNode.SelectSingleNode("//script[@id = 'hz-ctx']").InnerTextOrNull();


                if (jsonFilters != null)
                {
                    var responceInfo = JsonConvert.DeserializeObject<InterfaceFilter>(jsonFilters);
                    var test = "";
                    foreach (var item in responceInfo.data.stores.data.NavigationStore.data.filters)
                    {



                        
                        if (item.header == "Category") continue;
                        if (item.header == filter)
                        {
                            
                            foreach (var urls in item.options)
                            {
                                Filter filters = new Filter();
                                filters.Link = urls.url;
                                filters.Name = urls.label;
                                filtersUrl.Add(filters);
                            }
                        }

                        
                    }
                }



                return filtersUrl;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        protected override Action<ProcessQueueItem> GetItemProcessor(ProcessQueueItem item)
        {
            Action<ProcessQueueItem> act;
            if (item.ItemType == 50)
                act = ProcessSearchProduct;
            else if (item.ItemType == 10)
                act = ProcessProductListPage;
            //else if (item.ItemType == 20)
            //    act = ProcessCategoryListPage;
            //else if (item.ItemType == 30)
            //    act = ProcessSubCategoryListPage;
            else if (item.ItemType == 40)
                act = ProcessFindLinks;
            else act = null;
            return act;

            
        }
    }
}


