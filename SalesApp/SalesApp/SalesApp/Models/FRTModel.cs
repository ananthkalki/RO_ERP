using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesApp.Models
{
    public class FRTModel
    {
        [Display(Name = "RFQ Number")]
        [StringLength(10)]
        public string FRT1 { get; set; }
        
        [Display(Name = "Customer")]
        [StringLength(10)]
        public string FRT2 { get; set; }

        [Required(ErrorMessage = "Please select Delivery Method.")]
        [Display(Name = "Delivery Method")]
        public string FRT3 { get; set; }

        [Required(ErrorMessage = "Please select Currency.")]
        [Display(Name = "Currency")]
        public string FRT4 { get; set; }

        [Required(ErrorMessage = "Please select Vendor.")]
        [Display(Name = "Vendor")]
        public string FRT5 { get; set; }

        [Required(ErrorMessage = "Please select Source.")]
        [Display(Name = "Source")]
        public string FRT6 { get; set; }

        [Required(ErrorMessage = "Please select Destination.")]
        [Display(Name = "Destination")]
        public string FRT7 { get; set; }

        [Display(Name = "Weight(KG)")]
        public int FRT8 { get; set; }

        [Display(Name = "Rate(USD)")]
        public int FRT9 { get; set; }

        [Display(Name = "Frieght Budget Variation (USD)")]
        [StringLength(10)]
        public string FRT10 { get; set; }

        [StringLength(100)]
        [Display(Name = "Justification")]
        public string FRT11 { get; set; }

        public List<SelectListItem> Delivery_Method = new List<SelectListItem>();
        public List<SelectListItem> Currency = new List<SelectListItem>();
        public List<SelectListItem> Vendor = new List<SelectListItem>();
        public List<SelectListItem> Source = new List<SelectListItem>();
        public List<SelectListItem> Destination = new List<SelectListItem>();

    }
}