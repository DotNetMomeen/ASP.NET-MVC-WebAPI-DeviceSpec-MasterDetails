using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_API_MasterDetails.Models.ViewModels
{
    public class SpecInputModel
    {
        [Required, StringLength(50)]
        public string SpecName { get; set; }
        [Required, StringLength(50)]
        public string Value { get; set; }
    }
}