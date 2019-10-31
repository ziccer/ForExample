using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using WheelsScraper;

namespace Databox.Libs.eBayAIR
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
        public ScraperSettings Sett
        {
            get { return _sett; }
            set { _sett = value; if (_sett != null) RefreshBindings(); }
        }
        public ucExtSettings()
        {
            InitializeComponent();
        }

        protected void RefreshBindings()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ExtSett.Token = textBoxToken.Text;
        }

        private void ucExtSettings_Load(object sender, EventArgs e)
        {
            textBoxToken.Text = ExtSett.Token;
        }
    }
}
