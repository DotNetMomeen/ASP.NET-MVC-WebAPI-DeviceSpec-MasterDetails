using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_API_MasterDetails.Models
{
    public class Spec
    {
        public int SpecId { get; set; }
        [Required, StringLength(50)]
        public string SpecName { get; set; }
        [Required, StringLength(50)]
        public string Value { get; set; }
        [ForeignKey("Device")]
        public int DeviceId { get; set; }

        public Device Device { get; set; }
    }
}