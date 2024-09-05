using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_API_MasterDetails.Models
{
    public class DeviceDbContext:DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Spec> Specs { get; set; }
    }
}