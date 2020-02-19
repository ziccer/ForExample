using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutentificationASP.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CargoTransportation> CargoTransportations { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<HierList> HierLists { get; set; }

    }
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Roles.Add(new Role { Id = 1, Name = "admin" });
            db.Roles.Add(new Role { Id = 2, Name = "user" });
            db.Users.Add(new User { Id = 1, Email = "admin", Password = "admin", RoleId = 1 });
            db.Users.Add(new User { Id = 2, Email = "oleg", Password = "123123", RoleId = 1 });
            db.Users.Add(new User { Id = 3, Email = "guest", Password = "123321", RoleId = 2 });
            Town t1 = new Town { Name = "Dnepr" };
            Town t2 = new Town { Name = "Kyev" };
            Town t3 = new Town { Name = "Odessa" };
            Town t4 = new Town { Name = "Lvov" };
            Town t5 = new Town { Name = "Kharkov" };
            db.CargoTransportations.Add(new CargoTransportation
            {
                Id = 1,
                CityName = "Dnepr",
                Town = t4,
                PlannedAmount = 42,
                FactAmount = 18,
                DayOfMonth01 = 0,
                DayOfMonth02 = 1,
                DayOfMonth03 = 1,
                DayOfMonth04 = 0,
                DayOfMonth05 = 0,
                DayOfMonth06 = 1,
                DayOfMonth07 = 0,
                DayOfMonth08 = 0,
                DayOfMonth09 = 0,
                DayOfMonth10 = 0,
                DayOfMonth11 = 2,
                DayOfMonth12 = 0,
                DayOfMonth13 = 0,
                DayOfMonth14 = 3,
                DayOfMonth15 = 0,
                DayOfMonth16 = 0,
                DayOfMonth17 = 0,
                DayOfMonth18 = 1,
                DayOfMonth19 = 1,
                DayOfMonth20 = 1,
                DayOfMonth21 = 1,
                DayOfMonth22 = 0,
                DayOfMonth23 = 1,
                DayOfMonth24 = 1,
                DayOfMonth25 = 0,
                DayOfMonth26 = 0,
                DayOfMonth27 = 1,
                DayOfMonth28 = 0,
                DayOfMonth29 = 1,
                DayOfMonth30 = 2,
                DayOfMonth31 = 0,
            });
            db.CargoTransportations.Add(new CargoTransportation
            {
                Id = 1,
                CityName = "Kyev",
                Town = t3,
                PlannedAmount = 41,
                FactAmount = 24,
                DayOfMonth01 = 1,
                DayOfMonth02 = 3,
                DayOfMonth03 = 0,
                DayOfMonth04 = 2,
                DayOfMonth05 = 0,
                DayOfMonth06 = 0,
                DayOfMonth07 = 0,
                DayOfMonth08 = 2,
                DayOfMonth09 = 1,
                DayOfMonth10 = 2,
                DayOfMonth11 = 0,
                DayOfMonth12 = 0,
                DayOfMonth13 = 0,
                DayOfMonth14 = 1,
                DayOfMonth15 = 1,
                DayOfMonth16 = 1,
                DayOfMonth17 = 0,
                DayOfMonth18 = 1,
                DayOfMonth19 = 0,
                DayOfMonth20 = 1,
                DayOfMonth21 = 2,
                DayOfMonth22 = 0,
                DayOfMonth23 = 0,
                DayOfMonth24 = 0,
                DayOfMonth25 = 1,
                DayOfMonth26 = 0,
                DayOfMonth27 = 1,
                DayOfMonth28 = 0,
                DayOfMonth29 = 1,
                DayOfMonth30 = 1,
                DayOfMonth31 = 2,
            });
            db.CargoTransportations.Add(new CargoTransportation
            {
                Id = 1,
                CityName = "Dnepr",
                Town = t2,
                PlannedAmount = 32,
                FactAmount = 13,
                DayOfMonth01 = 0,
                DayOfMonth02 = 0,
                DayOfMonth03 = 1,
                DayOfMonth04 = 0,
                DayOfMonth05 = 3,
                DayOfMonth06 = 1,
                DayOfMonth07 = 0,
                DayOfMonth08 = 1,
                DayOfMonth09 = 0,
                DayOfMonth10 = 1,
                DayOfMonth11 = 0,
                DayOfMonth12 = 0,
                DayOfMonth13 = 0,
                DayOfMonth14 = 0,
                DayOfMonth15 = 1,
                DayOfMonth16 = 0,
                DayOfMonth17 = 0,
                DayOfMonth18 = 0,
                DayOfMonth19 = 1,
                DayOfMonth20 = 0,
                DayOfMonth21 = 0,
                DayOfMonth22 = 1,
                DayOfMonth23 = 0,
                DayOfMonth24 = 0,
                DayOfMonth25 = 0,
                DayOfMonth26 = 0,
                DayOfMonth27 = 1,
                DayOfMonth28 = 0,
                DayOfMonth29 = 1,
                DayOfMonth30 = 0,
                DayOfMonth31 = 1,
            });
            db.CargoTransportations.Add(new CargoTransportation
            {
                Id = 1,
                CityName = "Odessa",
                Town = t4,
                PlannedAmount = 50,
                FactAmount = 32,
                DayOfMonth01 = 0,
                DayOfMonth02 = 1,
                DayOfMonth03 = 1,
                DayOfMonth04 = 0,
                DayOfMonth05 = 4,
                DayOfMonth06 = 1,
                DayOfMonth07 = 0,
                DayOfMonth08 = 10,
                DayOfMonth09 = 0,
                DayOfMonth10 = 0,
                DayOfMonth11 = 2,
                DayOfMonth12 = 0,
                DayOfMonth13 = 0,
                DayOfMonth14 = 3,
                DayOfMonth15 = 0,
                DayOfMonth16 = 0,
                DayOfMonth17 = 0,
                DayOfMonth18 = 1,
                DayOfMonth19 = 1,
                DayOfMonth20 = 1,
                DayOfMonth21 = 1,
                DayOfMonth22 = 0,
                DayOfMonth23 = 1,
                DayOfMonth24 = 1,
                DayOfMonth25 = 0,
                DayOfMonth26 = 0,
                DayOfMonth27 = 1,
                DayOfMonth28 = 0,
                DayOfMonth29 = 1,
                DayOfMonth30 = 2,
                DayOfMonth31 = 0,
            });
            db.CargoTransportations.Add(new CargoTransportation
            {
                Id = 1,
                CityName = "Odessa",
                Town = t1,
                PlannedAmount = 105,
                FactAmount = 50,
                DayOfMonth01 = 11,
                DayOfMonth02 = 0,
                DayOfMonth03 = 0,
                DayOfMonth04 = 8,
                DayOfMonth05 = 4,
                DayOfMonth06 = 0,
                DayOfMonth07 = 6,
                DayOfMonth08 = 1,
                DayOfMonth09 = 0,
                DayOfMonth10 = 0,
                DayOfMonth11 = 1,
                DayOfMonth12 = 0,
                DayOfMonth13 = 0,
                DayOfMonth14 = 0,
                DayOfMonth15 = 2,
                DayOfMonth16 = 0,
                DayOfMonth17 = 0,
                DayOfMonth18 = 1,
                DayOfMonth19 = 1,
                DayOfMonth20 = 0,
                DayOfMonth21 = 0,
                DayOfMonth22 = 0,
                DayOfMonth23 = 4,
                DayOfMonth24 = 0,
                DayOfMonth25 = 3,
                DayOfMonth26 = 0,
                DayOfMonth27 = 0,
                DayOfMonth28 = 1,
                DayOfMonth29 = 1,
                DayOfMonth30 = 5,
                DayOfMonth31 = 1,
            });
            db.CargoTransportations.Add(new CargoTransportation
            {
                Id = 1,
                CityName = "Kharkov",
                Town = t4,
                PlannedAmount = 21,
                FactAmount = 19,
                DayOfMonth01 = 1,
                DayOfMonth02 = 0,
                DayOfMonth03 = 1,
                DayOfMonth04 = 1,
                DayOfMonth05 = 1,
                DayOfMonth06 = 0,
                DayOfMonth07 = 0,
                DayOfMonth08 = 1,
                DayOfMonth09 = 0,
                DayOfMonth10 = 1,
                DayOfMonth11 = 0,
                DayOfMonth12 = 0,
                DayOfMonth13 = 0,
                DayOfMonth14 = 1,
                DayOfMonth15 = 0,
                DayOfMonth16 = 0,
                DayOfMonth17 = 0,
                DayOfMonth18 = 0,
                DayOfMonth19 = 1,
                DayOfMonth20 = 0,
                DayOfMonth21 = 0,
                DayOfMonth22 = 0,
                DayOfMonth23 = 2,
                DayOfMonth24 = 0,
                DayOfMonth25 = 2,
                DayOfMonth26 = 0,
                DayOfMonth27 = 0,
                DayOfMonth28 = 1,
                DayOfMonth29 = 2,
                DayOfMonth30 = 2,
                DayOfMonth31 = 2,
            });

            var menuItems = new List<HierList>
                {
                    new HierList{Id=1, Header = "Dnepr", Url = "#", Order = 1},
                    new HierList{Id=2, Header = "Kyev", Url = "#", Order = 2},
                    new HierList{Id=3, Header = "Odessa", Url = "#", Order = 3},
                    new HierList{Id=4, Header = "Kharkov", Url = "#", Order = 4},
                    new HierList{Id=5, Header = "Lvov", Url = "#", Order = 1, ParentId = 1, Planning = 42, Fact = 18},
                    new HierList{Id=6, Header = "Kyev", Url = "#", Order = 2, ParentId = 1, Planning = 32, Fact = 13},
                    new HierList{Id=7, Header = "Odessa", Url = "#",  Order = 1, ParentId = 2, Planning = 41, Fact = 24},
                    new HierList{Id=8, Header = "Lvov", Url = "#", Order = 2, ParentId = 3, Planning = 50, Fact = 32},
                    new HierList{Id=9, Header = "Dnepr", Url = "#", Order = 3, ParentId = 3, Planning = 105, Fact = 50},
                    new HierList{Id=10, Header = "Lvov", Url = "#", Order = 3, ParentId = 4, Planning = 21, Fact = 19}
                };
            db.HierLists.AddRange(menuItems);


            db.SaveChanges();
            base.Seed(db);
        }
    }
}