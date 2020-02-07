using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutentificationASP.Models
{
    public class CargoTransportation
    {
        public int Id { get; set; }
        public string CityName { get; set; }
      //public string ToCity { get; set; }
        public int PlannedAmount { get; set; }
        public int DayOfMonth01 { get; set; }
        public int DayOfMonth02 { get; set; }
        public int DayOfMonth03 { get; set; }
        public int DayOfMonth04 { get; set; }
        public int DayOfMonth05 { get; set; }
        public int DayOfMonth06 { get; set; }
        public int DayOfMonth07 { get; set; }
        public int DayOfMonth08 { get; set; }
        public int DayOfMonth09 { get; set; }
        public int DayOfMonth10 { get; set; }
        public int DayOfMonth11 { get; set; }
        public int DayOfMonth12 { get; set; }
        public int DayOfMonth13 { get; set; }
        public int DayOfMonth14 { get; set; }
        public int DayOfMonth15 { get; set; }
        public int DayOfMonth16 { get; set; }
        public int DayOfMonth17 { get; set; }
        public int DayOfMonth18 { get; set; }
        public int DayOfMonth19 { get; set; }
        public int DayOfMonth20 { get; set; }
        public int DayOfMonth21 { get; set; }
        public int DayOfMonth22 { get; set; }
        public int DayOfMonth23 { get; set; }
        public int DayOfMonth24 { get; set; }
        public int DayOfMonth25 { get; set; }
        public int DayOfMonth26 { get; set; }
        public int DayOfMonth27 { get; set; }
        public int DayOfMonth28 { get; set; }
        public int DayOfMonth29 { get; set; }
        public int DayOfMonth30 { get; set; }
        public int DayOfMonth31 { get; set; }
        public int FactAmount { get; set; }
        public int? TownId { get; set; }
        public Town Town { get; set; }
    }
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CargoTransportation> CargoTransportation { get; set; }
        public Town()
        {
            CargoTransportation = new List<CargoTransportation>();
        }
    }
    public class CargoTransportationListViewModel
    {
        public IEnumerable<CargoTransportation> CargoTransportations { get; set; }
        public SelectList CityNames { get; set; }
        public SelectList Towns { get; set; }
    }
}