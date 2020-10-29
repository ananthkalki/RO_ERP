using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesApp.Models
{
    public class VPRModel
    {
        [Display(Name = "RFQ Number")]
        [StringLength(10)]
        public string PS02001 { get; set; }

        [Display(Name = "Customer")]
        [StringLength(10)]
        public string SL01002 { get; set; }
        
        [Display(Name = "Vendor")]
        [StringLength(15)]
        public string PS02018 { get; set; }

        [Display(Name = "Category")]
        [StringLength(35)]
        [Required(ErrorMessage = "Please enter Customer Reference")]
        public string PS02019 { get; set; }

        [Display(Name = "Currency")]
        [StringLength(35)]
        [Required(ErrorMessage = "Please enter Customer Reference")]
        public string PS02020 { get; set; }

        [Display(Name = "Vendor")]
        [StringLength(35)]
        public string PS02013 { get; set; }

      
        [StringLength(100)]
        [Display(Name = "Remarks")]
        public string PS02022 { get; set; }

        public List<SelectListItem> Vendor= new List<SelectListItem>();




    }
}