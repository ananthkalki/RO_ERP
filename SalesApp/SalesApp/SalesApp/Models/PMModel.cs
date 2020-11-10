using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SalesApp.Models
{
    public class PMModel
    {
        [Display(Name = "RFQ Number")]
        [StringLength(10)]
        public string PM1 { get; set; }

        [Display(Name = "Customer")]
        [StringLength(10)]
        public string PM2 { get; set; }

        [Required(ErrorMessage = "Please select Currency.")]
        [Display(Name = "Currency")]
        public string PM3 { get; set; }

        [Display(Name = "Valid Upto")]
        [Required(ErrorMessage = "Please enter Valid Upto date.")]
        public DateTime PM4 { get; set; }

        [Display(Name = "Profit % of all items")]
        [StringLength(10)]
        public string PM5 { get; set; }

        [Required(ErrorMessage = "Please select Logo")]
        [Display(Name = "Choose Logo")]
        public string PM6 { get; set; }

        [Display(Name = "Domestic Frieght")]
        public int PM7 { get; set; }

        [Display(Name = "Total Frieght")]
        public int PM8 { get; set; }

        [Required(ErrorMessage = "Please select INCOTERM")]
        [Display(Name = "INCOTERM")]
        public string PM9 { get; set; }

        [Display(Name = "Frieght")]
        public int PM10 { get; set; }

        [Display(Name = "Total")]
        public int PM11 { get; set; }

        [Display(Name = "Frieght Profit Amount")]
        public int PM12 { get; set; }

        [Display(Name = "VAT")]
        public int PM13 { get; set; }

        [Display(Name = "Quote Date")]
        [Required(ErrorMessage = "Please enter Quote date.")]
        public DateTime PM14 { get; set; }

        [Display(Name = "Discount Value, If any")]
        public int PM15 { get; set; }

        [Display(Name = "Grand Total")]
        public int PM16 { get; set; }

        [StringLength(100)]
        [Display(Name = "Delivery Terms")]
        public string PM17 { get; set; }

        [StringLength(100)]
        [Display(Name = "Notes")]
        public string PM18 { get; set; }

        [StringLength(100)]
        [Display(Name = "Additional Notes")]
        public string PM19 { get; set; }


        public List<SelectListItem> Currency = new List<SelectListItem>();
        public List<SelectListItem> Logo = new List<SelectListItem>();
        public List<SelectListItem> Incoterm = new List<SelectListItem>();
    }
}