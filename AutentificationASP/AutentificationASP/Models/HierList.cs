using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutentificationASP.Models
{
    public class HierList
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Url { get; set; }
        public int Planning { get; set; }
        public int Fact { get; set; }
        public int? Order { get; set; }
        public int? ParentId { get; set; }
        public HierList Parent { get; set; }

        public ICollection<HierList> Children { get; set; }
        public HierList()
        {
            Children = new List<HierList>();
        }
    }
}