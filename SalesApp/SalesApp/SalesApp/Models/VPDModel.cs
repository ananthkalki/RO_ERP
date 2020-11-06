using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesApp.Models
{
    public class VPDModel
    {
        [Display(Name = "Order#")]
        [StringLength(10)]
        public string vpd1 { get; set; }

        [Display(Name = "Vendor")]
        [StringLength(35)]
        public string PS02013 { get; set; }

        [Display(Name = "Currency")]
        [StringLength(35)]
        public string vpd2 { get; set; }

        public List<SelectListItem> Vendor = new List<SelectListItem>();
        public List<SelectListItem> Currency = new List<SelectListItem>();

    }
}