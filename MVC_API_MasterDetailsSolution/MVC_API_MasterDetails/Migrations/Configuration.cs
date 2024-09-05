namespace MVC_API_MasterDetails.Migrations
{
    using MVC_API_MasterDetails.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_API_MasterDetails.Models.DeviceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_API_MasterDetails.Models.DeviceDbContext context)
        {
            Device d = new Device
            {
                DeviceName = "S23 Ultra",
                ReleaseDate = new DateTime(2023, 10, 10),
                OnSale = true,
                Picture = "1.jpg",
                Price = 120000.00M
            };
            d.Specs.Add(new Spec
            {
                SpecName = "RAM",
                Value = "128GB"
            });
            d.Specs.Add(new Spec
            {
                SpecName = "Camera",
                Value = "108MP"
            });

            context.Devices.Add(d);
            context.SaveChanges();
        }
    }
}
