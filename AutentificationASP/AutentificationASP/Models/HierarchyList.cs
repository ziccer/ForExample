using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutentificationASP.Models
{
    public class HierarchyList
    {
        public int Id { get; set; }
        public string FromCity { get; set; }  
        public string ToCity { get; set; }
        public string Plan { get; set; }
        public string Fact { get; set; }
    }
}