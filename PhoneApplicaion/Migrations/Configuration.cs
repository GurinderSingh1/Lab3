namespace PhoneApplicaion.Migrations
{
    using PhoneApplicaion.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
   

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneApplicaion.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoneApplicaion.Models.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var manufacturers = new List<Manufacturer>
{
new Manufacturer {
ManufacturerName = "Apple",
Url = "www.apple.ca",
Founded = new DateTime(1968,10,20),
PhoneList = new List<Phone>() },
new Manufacturer {
ManufacturerName = "Samsung",
Url = "www.samsung.ca",
Founded = new DateTime(1950,10,20),
PhoneList = new List<Phone>()  },
};
            manufacturers.ForEach(s => context.Manufacturers.Add(s));
            context.SaveChanges();

            var Phones = new List<Phone>
{
new Phone {
PhoneName = "iPhone 11 Pro",
msrp = 1500,
DateReleased = new DateTime(2019,10,20),
ManufacturerId = manufacturers.Single(x => x.ManufacturerName == "Apple").ManufacturerId
},
new Phone {
PhoneName = "iPhone XR",
msrp = 1000,
DateReleased = new DateTime(2018,01,20),
ManufacturerId = manufacturers.Single(x => x.ManufacturerName == "Apple").ManufacturerId },
new Phone {
PhoneName = "Galaxy S10",
msrp = 700,
DateReleased = new DateTime(2016,10,20),
ManufacturerId = manufacturers.Single(x =>  x.ManufacturerName == "Samsung").ManufacturerId  }
};
            Phones.ForEach(s => context.Phone.Add(s));
            context.SaveChanges();

        }
    }
}
