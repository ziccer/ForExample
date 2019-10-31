using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using Scraper.Shared;
using System.Web;
using HtmlAgilityPack;
using eBayAIR;
using Databox.Libs.eBayAIR;
using eBayAIR.eBayTF;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Xml;
using System.IO;
using System.Text;
using System.Net;

namespace WheelsScraper
{
    public class eBayAIR : BaseScraper
    {
        FileTransferServicePortClient FTSPC = null;
        BulkDataExchangeServicePortClient BDESPC = null;
        public eBayAIR()
        {
            Name = "eBayAIR";
            Url = "https://www.eBayAIR.com/";
            PageRetriever.Referer = Url;
            WareInfoList = new List<ExtWareInfo>();
            Wares.Clear();
            BrandItemType = 2;

            SpecialSettings = new ExtSettings();
            Complete += EBayAIR_Complete;
        }
        List<Inventory> prods = new List<Inventory>();
        public void testFTP()
        {
            Inventory testSKU = new Inventory()
            {
                Sku = "123456789",
                Price = "23.23",
                Quantity = "4",
                ItemId = "11111111"

            };
            prods.Add(testSKU);

        }
        private void EBayAIR_Complete(object sender, EventArgs e)
        {
            try
            {
                //testFTP();

                MessagePrinter.PrintMessage($"Product count: " + prods.Count());
                if (prods.Count > 0)
                {

                    string fileName = "eBay_ActiveInventoryReport.csv";
                    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                    string separator = ",";
                    string headers = "SKU,Quantity";
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(headers);

                    foreach (Inventory item in prods)
                    {
                        string[] productArr = new string[2] { item.Sku, item.Quantity};

                        for (int i = 0; i < productArr.Length; i++)
                            if (!String.IsNullOrEmpty(productArr[i]) && !String.IsNullOrWhiteSpace(productArr[i]))
                                productArr[i] = StringToCSVCell(productArr[i]);

                        string product = String.Join(separator, productArr);
                        sb.AppendLine(product);
                    }

                    File.WriteAllText(filePath, sb.ToString());

                    MessagePrinter.PrintMessage($"file created in {filePath}");

                    try
                    {
                        MessagePrinter.PrintMessage($"Upload on FTP");

                        string url = Ftp.UploadFtp(Settings.FtpAddress, Settings.FtpUsername,
                            Settings.FtpPassword, fileName, filePath, true);
                        if (!string.IsNullOrEmpty(url))
                        {
                            MessagePrinter.PrintMessage("File uploaded: " + url);
                        }
                    }
                    catch (System.Exception y)
                    {
                        MessagePrinter.PrintMessage($"{y.Message} - when upload Premier file on FTP");
                    }
                   
                }
            }
            catch (Exception ex)
            {

                
            }


        }
        public static string StringToCSVCell(string str)
        {
            bool mustQuote = (str.Contains(",") || str.Contains("\"") || str.Contains("\r") || str.Contains("\n"));
            if (mustQuote)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\"");
                foreach (char nextChar in str)
                {
                    sb.Append(nextChar);
                    if (nextChar == '"')
                        sb.Append("\"");
                }
                sb.Append("\"");
                return sb.ToString();
            }

            return str;
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
        static string tokenClient;
        
        protected override void RealStartProcess()
        {
            lstProcessQueue.Add(new ProcessQueueItem { URL = Url, ItemType = 1 });
            StartOrPushPropertiesThread();
        }

        protected void ProcessBrandsListPage(ProcessQueueItem pqi)
        {
            if (cancel)
                return;
            
            tokenClient = extSett.Token;
            if (tokenClient != null)
            {
                getActiveInventoryReport();
                
            }
            pqi.Processed = true;
            StartOrPushPropertiesThread();
        }
        public void getActiveInventoryReport()
        {
            int countSleep = 0;
            var job = "ActiveInventoryReport";
            MessagePrinter.PrintMessage("Request data from eBay"); 
            StartDownloadJobResponse jobIdField = StartDownloadJob(job);
          
            
            
            if (jobIdField.jobId != null)
            {
                MessagePrinter.PrintMessage("Waiting for a response from the server");
                System.Threading.Thread.Sleep(TimeSpan.FromMinutes(1));
                MessagePrinter.PrintMessage("Service Request from eBay"); 
                var fileId = GetJobStatusRequest(jobIdField.jobId);

                while (fileId.jobProfile[0].fileReferenceId == null && countSleep < 20) 
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
                    countSleep++;
                    MessagePrinter.PrintMessage("Waiting for a response from the server");
                    fileId = GetJobStatusRequest(jobIdField.jobId);
                }
                try
                {
                    if (fileId.jobProfile != null)
                    {
                        string TaskRefID = fileId.jobProfile[0].jobId;
                        string FileRefID = fileId.jobProfile[0].fileReferenceId;
                        if (TaskRefID != null && FileRefID != null)
                        {
                            MessagePrinter.PrintMessage("Response received");
                            MessagePrinter.PrintMessage("Job ID = " + TaskRefID + ", File ID = " + FileRefID);
                            if (FileRefID != null)
                            {
                                MessagePrinter.PrintMessage("Downloading file. Please wair...");
                                string pathXMLReport = downloadFile(TaskRefID, FileRefID, tokenClient);
                                MessagePrinter.PrintMessage("File dowloaded.");
                                MessagePrinter.PrintMessage("Processing the data");
                                LoadItems(pathXMLReport);
                                MessagePrinter.PrintMessage("Processed");
                            }
                        }
                        else MessagePrinter.PrintMessage("Server is not responding, try again later...");
                    } else MessagePrinter.PrintMessage("jobProfile is empty");
                }
                catch (Exception ex) { MessagePrinter.PrintMessage(ex.StackTrace); }
            }
            else { MessagePrinter.PrintMessage("Connection limit exceeded. Try later..."); }
        }
        public string downloadFile(string jobID, string OutFileRefID, string token)
        {
            
            string TaskRefID = jobID;
            string FileRefID = OutFileRefID;
            string endPoint = "https://storage.ebay.com/FileTransferService";

            string downloadFileRequest = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"
                                                + "<downloadFileRequest xmlns:sct=\"http://www.ebay.com/soaframework/common/types\" xmlns=\"http://www.ebay.com/marketplace/services\">"
                                                + "<taskReferenceId>" + TaskRefID + "</taskReferenceId>"
                                                + "<fileReferenceId>" + FileRefID + "</fileReferenceId>"
                                                + "</downloadFileRequest>";

            HttpWebRequest httpRequest;
            WebResponse webResponse;
            StringBuilder sbResp = new StringBuilder();

            System.Text.Encoding iso8859 = System.Text.Encoding.GetEncoding("ISO-8859-1");

            //Create the HTTP request and set the headers
            httpRequest = (HttpWebRequest)WebRequest.Create(endPoint);

            httpRequest.Headers.Add("X-EBAY-SOA-SECURITY-TOKEN", token);
            httpRequest.Headers.Add("X-EBAY-SOA-SERVICE-NAME", "FileTransferService");
            httpRequest.Headers.Add("X-EBAY-SOA-SERVICE-VERSION", "1.0.0");
            httpRequest.Headers.Add("X-EBAY-SOA-OPERATION-NAME", "downloadFile");

            httpRequest.Method = "POST";

            //Put the data into a UTF8 encoded  byte array
            UTF8Encoding encoding = new UTF8Encoding();
            int dataLen = encoding.GetByteCount(downloadFileRequest);
            byte[] utf8Bytes = new byte[dataLen];
            Encoding.UTF8.GetBytes(downloadFileRequest, 0, downloadFileRequest.Length, utf8Bytes, 0);

            Stream Streamobj = null;

            //Set the request Stream
            Streamobj = httpRequest.GetRequestStream();

            //Write the request to the Request Steam
            Streamobj.Write(utf8Bytes, 0, utf8Bytes.Length);
            Streamobj.Close();

            //Get response into stream
            webResponse = httpRequest.GetResponse();
            Streamobj = webResponse.GetResponseStream();

            // Get Response into StringBuilder object
            char[] buf = new char[4096];
            int len;
            System.IO.StreamReader sr = new StreamReader(Streamobj, iso8859);

            try
            {
                while ((len = sr.Read(buf, 0, buf.Length)) > 0)
                {
                    sbResp.Append(buf, 0, len);
                }
                MessagePrinter.PrintMessage("File download successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error download file");
                MessagePrinter.PrintMessage("Error download file");
                MessagePrinter.PrintMessage(ex.StackTrace);
                MessagePrinter.PrintMessage(ex.Message);
                
            }

            sr.Close();
            Streamobj.Close();


            if (sbResp.ToString() != "")
            {


                int StartIndex = sbResp.ToString().LastIndexOf("Content-ID: <urn:uuid:");
                int EndIndex = sbResp.ToString().LastIndexOf("--MIMEBoundaryurn_uuid_");
                EndIndex -= 2;

                //32 = Length of UUID, 4 for the 2 CRLFs
                StartIndex += "Content-ID: <urn:uuid:".Length + 32 + 4;

                string attchmnt = sbResp.ToString().Substring(StartIndex, (EndIndex - StartIndex));

                byte[] data = iso8859.GetBytes(attchmnt);


                string fileName = "report_" + TaskRefID + ".zip";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                using (FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    fstream.Write(data, 0, data.Length);
                    //Console.WriteLine("Текст записан в файл");
                }

                //string path = @"C:\downloadedFile.zip";

                // Write to zip file
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                FileStream fs = File.Create(filePath);
                fs.Write(data, 0, data.Length);
                fs.Close();
                
                string fileNameUnZip = TaskRefID + "_report.xml";
                string filePathUnZip = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileNameUnZip);

                var extractPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                if (File.Exists(filePathUnZip))
                {
                    File.Delete(filePathUnZip);
                }

                System.IO.Compression.ZipFile.ExtractToDirectory(filePath, extractPath);
                return filePathUnZip;

            }
            else
            {
                Console.WriteLine("Error fetching response");
                return null;
            }
        }
        private void LoadItems(string path)
        {
            
            int count = 0;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            var node = xmlDoc.GetElementsByTagName("SKUDetails");
            foreach (XmlNode item in node)
            {
                try
                {
                    var skuInfo = item["ItemID"].InnerText;
                    Inventory product = new Inventory()
                    {
                        Sku = item["SKU"].InnerText,
                        Price = item["Price"].InnerText,
                        Quantity = item["Quantity"].InnerText,
                        ItemId = item["ItemID"].InnerText
                    };
                    prods.Add(product);
                    
                }
                catch (Exception ex)
                {
                    count++;
                    MessagePrinter.PrintMessage(count + " ItemID " + item["ItemID"].InnerText +" wrong format");
                }

            }
        }
        public class Inventory
        {
            public string Sku { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string ItemId { get; set; }
        }
        public HttpRequestMessageProperty setHeadersDownloadFile(HttpRequestMessageProperty httpRequest, string SecurityToken)
        {

            httpRequest.Headers.Add("X-EBAY-SOA-SECURITY-TOKEN", SecurityToken);
            httpRequest.Headers.Add("X-EBAY-SOA-OPERATION-NAME", "downloadFile");
            httpRequest.Headers.Add("X-EBAY-SOA-SERVICE-NAME", "FileTransferService");
            httpRequest.Headers.Add("X-EBAY-SOA-SERVICE-VERSION", "1.0.0");
            httpRequest.Method = "POST";


            return httpRequest;
        }
        public StartDownloadJobResponse StartDownloadJob(string job)
        {

            BulkDataExchangeServicePortClient client = BulkDataExchangeService;
            using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
            {

                HttpRequestMessageProperty httpRequest = new HttpRequestMessageProperty();
                OperationContext.Current.OutgoingMessageProperties.Add(HttpRequestMessageProperty.Name, httpRequest);

                //Add the request headers
                setHeaders(httpRequest, tokenClient);

                //Create the request
                StartDownloadJobRequest req = new StartDownloadJobRequest();

                //Supply additional parameters

                //The UUID must be unique.  Once used, you can't use it again
                req.UUID = System.Guid.NewGuid().ToString();

                //Specify job type
                req.downloadJobType = job;
                //req.fileType = FileType.XML;

                //Get the response
                StartDownloadJobResponse resp = client.startDownloadJob(req);
                return resp;

            }
        }
        public HttpRequestMessageProperty setHeaders(HttpRequestMessageProperty httpRequest, string SecurityToken)
        {

            httpRequest.Headers.Add("X-EBAY-SOA-SECURITY-TOKEN", SecurityToken);
            httpRequest.Headers.Add("X-EBAY-SOA-MESSAGE-PROTOCOL", "SOAP12");
            httpRequest.Headers.Add("X-EBAY-SOA-OPERATION-NAME", "startDownloadJob");

            return httpRequest;
        }
        public GetJobStatusResponse GetJobStatusRequest(string id)
        {

            BulkDataExchangeServicePortClient client = BulkDataExchangeService;
            using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
            {

                HttpRequestMessageProperty httpRequest = new HttpRequestMessageProperty();
                OperationContext.Current.OutgoingMessageProperties.Add(HttpRequestMessageProperty.Name, httpRequest);

                //Add the request headers
                setHeadersGetJob(httpRequest, tokenClient);

                //Create the request
                GetJobStatusRequest req = new GetJobStatusRequest();

                //Supply additional parameters

                //The UUID must be unique.  Once used, you can't use it again


                //Specify job type
                req.jobId = id;
                //req.fileType = FileType.XML;

                //Get the response
                GetJobStatusResponse resp = client.getJobStatus(req);
                return resp;

            }


        }
        public HttpRequestMessageProperty setHeadersGetJob(HttpRequestMessageProperty httpRequest, string SecurityToken)
        {

            httpRequest.Headers.Add("X-EBAY-SOA-SECURITY-TOKEN", SecurityToken);
            httpRequest.Headers.Add("X-EBAY-SOA-MESSAGE-PROTOCOL", "SOAP12");
            httpRequest.Headers.Add("X-EBAY-SOA-OPERATION-NAME", "getJobStatus");

            return httpRequest;
        }
        protected override Action<ProcessQueueItem> GetItemProcessor(ProcessQueueItem item)
        {
            Action<ProcessQueueItem> act;
            if (item.ItemType == 1)
                act = ProcessBrandsListPage;
            else act = null;

            return act;
        }
        

        public BulkDataExchangeServicePortClient BulkDataExchangeService
        {
            get
            {
                if ((BDESPC == null))
                {
                    TextMessageEncodingBindingElement encoding = new TextMessageEncodingBindingElement(MessageVersion.Soap12, System.Text.Encoding.UTF8);
                    encoding.MaxReadPoolSize = 64;
                    encoding.MaxWritePoolSize = 16;

                    encoding.ReaderQuotas.MaxDepth = 32;
                    encoding.ReaderQuotas.MaxStringContentLength = 8192;
                    encoding.ReaderQuotas.MaxArrayLength = 16384;
                    encoding.ReaderQuotas.MaxBytesPerRead = 4096;
                    encoding.ReaderQuotas.MaxNameTableCharCount = 16384;

                    HttpsTransportBindingElement transport = new HttpsTransportBindingElement();

                    transport.ManualAddressing = false;
                    transport.MaxBufferPoolSize = 24 * 1024 * 1024;
                    transport.MaxReceivedMessageSize = 8 * 1024 * 1024;
                    transport.AllowCookies = false;
                    transport.AuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
                    transport.BypassProxyOnLocal = false;
                    transport.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
                    transport.KeepAliveEnabled = true;
                    transport.MaxBufferSize = 8 * 1024 * 1024;
                    transport.ProxyAuthenticationScheme = System.Net.AuthenticationSchemes.Anonymous;
                    transport.Realm = "";
                    transport.TransferMode = TransferMode.Buffered;
                    transport.UnsafeConnectionNtlmAuthentication = false;
                    transport.UseDefaultWebProxy = true;


                    System.ServiceModel.Channels.CustomBinding binding = new System.ServiceModel.Channels.CustomBinding(encoding, transport);
                    System.ServiceModel.EndpointAddress ea = new System.ServiceModel.EndpointAddress("https://webservices.ebay.com/BulkDataExchangeService");

                    BDESPC = new BulkDataExchangeServicePortClient(binding, ea);
                }

                return BDESPC;
            }
        }
        public FileTransferServicePortClient FileTransferService
        {
            get
            {
                if ((FTSPC == null))
                {
                    MtomMessageEncodingBindingElement encoding = new MtomMessageEncodingBindingElement(MessageVersion.Soap12, System.Text.Encoding.UTF8);
                    HttpsTransportBindingElement transport = new HttpsTransportBindingElement();

                    transport.MaxReceivedMessageSize = 10 * 1024 * 1024;

                    System.ServiceModel.Channels.CustomBinding binding = new System.ServiceModel.Channels.CustomBinding(encoding, transport);
                    binding.SendTimeout = new TimeSpan(0, 5, 0);
                    binding.ReceiveTimeout = new TimeSpan(0, 5, 0);
                    System.ServiceModel.EndpointAddress ea = new System.ServiceModel.EndpointAddress("https://storage.ebay.com/FileTransferService");

                    FTSPC = new FileTransferServicePortClient(binding, ea);
                }

                return FTSPC;
            }
        }
    }
}
