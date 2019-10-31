using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WheelsScraper;

namespace Databox.Libs.Houzz
{
    public partial class ucExtSettings : XtraUserControl
    {
        public ExtSettings ExtSett
        {
            get
            {
                return (ExtSettings)Sett.SpecialSettings;
            }
        }

        ScraperSettings _sett;
        Dictionary<string, string> dicNameUrl = new Dictionary<string, string>();
        Dictionary<string, string> filtersUrl = new Dictionary<string, string>();
        public static List<string> links = new List<string>();
        public ScraperSettings Sett
        {
            get { return _sett; }
            set { _sett = value; /*if (_sett != null) RefreshBindings();*/ }
        }
        public ucExtSettings()
        {
           

            InitializeComponent();
            checkedListBoxControl1.Enabled = true;
            checkedListBoxControl2.Enabled = false;
            checkedListBoxControl3.Enabled = false;
            checkedListBoxControl4.Enabled = false;
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = false;
            simpleButton6.Enabled = false;
            checkEdit1.Enabled = true;
            checkedListBoxControl1.Visible = false;
            WheelsScraper.Houzz hz = new WheelsScraper.Houzz();

            var cat = hz.GetListCategory();
            foreach (var item in cat)
            {
                checkedListBoxControl1.Items.Add(item.Name);

            }
            
        }
        string generalLink = "";
        protected void RefreshBindings()
        {
            
        }

        //private void btnGetItem_Click(object sender, EventArgs e)
        //{
        //    listBoxItem.Items.Clear();
        //    foreach (string s in checkedListBox.CheckedItems)
        //    {
        //        listBoxItem.Items.Add(s);
        //    }
        //}

        //private void btnGetIndex_Click(object sender, EventArgs e)
        //{
        //    listBoxIndex.Items.Clear();
        //    for (int i = 0; i< checkedListBox.CheckedIndices.Count; i++)
        //    {
        //        listBoxIndex.Items.Add(checkedListBox.CheckedIndices[i]);
        //    }
        //}

        private void listBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                ExtSett.Option1 = true;
            }
            else
            {
                ExtSett.Option1 = false;
            }
        }

        private void ucExtSettings_Load(object sender, EventArgs e)
        {
            if (ExtSett.Option1 == true)
            {
                checkEdit1.Checked = true;
            }
            else checkEdit1.Checked = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            checkedListBoxControl2.Items.Clear();
            simpleButton2.Enabled = true;
            checkedListBoxControl2.Enabled = true;
            try
            {
                if (checkedListBoxControl1.CheckedItems.Count == 1)
                {
                    checkedListBoxControl1.Enabled = false;

                    WheelsScraper.Houzz hzSub = new WheelsScraper.Houzz();
                    var name = checkedListBoxControl1.CheckedItems;
                    var nameCategory = "";
                    foreach (var item in name)
                    {
                        nameCategory = item.ToString();
                    }
                    WheelsScraper.Houzz hz = new WheelsScraper.Houzz();

                    var searchLink = hz.GetListCategory();
                    var nameLink = "";
                    foreach (var item in searchLink)
                    {
                        if (item.Name == nameCategory)
                        {
                            nameLink = item.Link;
                        }

                    }

                    //var nameLink = "https://www.houzz.com/products/bath-products";
                    var subCat = hzSub.GetListSubCat(nameLink);

                    foreach (var item in subCat)
                    {
                        var nameCat = item.Name;
                        var url = item.Link;
                        dicNameUrl.Add(nameCat, url);
                        checkedListBoxControl2.Items.Add(item.Name);

                    }
                }
                else
                {
                    MessageBox.Show("Please select only ONE Category! ");
                }
                simpleButton1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            checkedListBoxControl3.Items.Clear();
            simpleButton3.Enabled = true;
            checkedListBoxControl3.Enabled = true;

            if (checkedListBoxControl2.CheckedItems.Count == 1)
            {
                checkedListBoxControl2.Enabled = false;
                WheelsScraper.Houzz hzFilters = new WheelsScraper.Houzz();
                var name = checkedListBoxControl2.CheckedItems;
                var nameFilters = "";
                foreach (var item in name)
                {
                    nameFilters = item.ToString();
                }
                var link = string.Empty;
                foreach (var item in dicNameUrl)
                {
                    if (item.Key == nameFilters)
                    {
                        link = item.Value;
                        generalLink = item.Value;
                        break;
                    }
                }


                WheelsScraper.Houzz hz = new WheelsScraper.Houzz();
                //var link = "https://www.houzz.com/products/showers";
                
                var searchLink = hz.GetListFilters(link);
                foreach (var item in searchLink)
                {
                    checkedListBoxControl3.Items.Add(item.Name);
                }
                
            }
            else
            {
                MessageBox.Show("Please select only ONE SubCategory! ");
            }
            simpleButton2.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            checkedListBoxControl1.Enabled = true;
            checkedListBoxControl2.Enabled = false;
            checkedListBoxControl3.Enabled = false;
            checkedListBoxControl4.Enabled = true;
            checkedListBoxControl2.Items.Clear();
            checkedListBoxControl3.Items.Clear();
            checkedListBoxControl4.Items.Clear();
            checkedListBoxControl1.UnCheckSelectedItems();
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = false;
            simpleButton4.Enabled = true;
            checkEdit1.Enabled = true;
            listBoxControl1.Items.Clear();
            dicNameUrl.Clear();
            filtersUrl.Clear();
            links.Clear();
            generalLink = string.Empty;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            checkedListBoxControl4.Items.Clear();
            simpleButton6.Enabled = true;
            checkedListBoxControl4.Enabled = true;

            if (checkedListBoxControl3.CheckedItems.Count == 1)
            {
                checkedListBoxControl3.Enabled = false;
                var name = checkedListBoxControl3.CheckedItems;
                var nameFilters = "";
                foreach (var item in name)
                {
                    nameFilters = item.ToString();
                }
                var link = string.Empty;
                WheelsScraper.Houzz hz = new WheelsScraper.Houzz();
                var searchLinkFilter = hz.FindFilterByName(generalLink, nameFilters);

              
                foreach (var item in searchLinkFilter)
                {
                    checkedListBoxControl4.Items.Add(item.Name);
                    filtersUrl.Add(item.Name, item.Link);
                }

            }
            else
            {
                MessageBox.Show("Please select only ONE Filter name! ");
            }
            simpleButton3.Enabled = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
            links.Clear();

            checkEdit1.Enabled = false;
            if (checkedListBoxControl4.CheckedItems.Count > 0)
            {
                listBoxControl1.Items.Clear();

                foreach (var item in checkedListBoxControl4.CheckedItems)
                {
                    var name = item.ToString();
                    foreach (var itemFilters in filtersUrl)
                    {
                        if (itemFilters.Key == name)
                        {
                            links.Add(itemFilters.Value);
                        }
                    }
                }
                if (links != null)
                {
                    foreach (var item in links)
                    {
                        listBoxControl1.Items.Add(item);
                    }
                    
                }
                
            }
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
        }
    }
}
