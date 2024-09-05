using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_API_MasterDetails.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        [Required, StringLength(50)]
        public string DeviceName { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }
        public bool OnSale { get; set; }
        [StringLength(150)]
        public string Picture { get; set; }

        public ICollection<Spec> Specs { get; set; } = new List<Spec>();
    }
}