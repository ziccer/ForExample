using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houzz.Helper
{
    public class JsonEnum
    {
        public string context { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public Itemlistelement[] itemListElement { get; set; }
    }

    public class Itemlistelement
    {
        public string type { get; set; }
        public int position { get; set; }
        public string url { get; set; }
    }

    
}
