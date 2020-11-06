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

        [Display(Name = "Domestic Freight")]
        [StringLength(15)]
        public string vdp3 { get; set; }

        [Display(Name = "Deliver To")]
        [StringLength(15)]
        public string vdp4 { get; set; }

        [Display(Name = "Valid Upto")]
        [Required(ErrorMessage = "Please enter Price by date.")]
        public DateTime vdp5 { get; set; }

        [Display(Name = "Stock Availability")]
        [StringLength(15)]
        public string vdp6 { get; set; }

        [Display(Name = "Lead Time")]
        [StringLength(15)]
        public string vdp7 { get; set; }

        [StringLength(100)]
        [Display(Name = "Remarks")]
        public string vdp8 { get; set; }

        public List<SelectListItem> Vendor = new List<SelectListItem>();
        public List<SelectListItem> Currency = new List<SelectListItem>();

    }
}