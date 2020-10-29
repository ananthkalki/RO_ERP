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
        [Display(Name = "RFQ Date")]
        [Required(ErrorMessage = "Please enter RFQ date.")]
        public DateTime PS02006 { get; set; }

        [Display(Name = "Quote By")]
        [Required(ErrorMessage = "Please enter Quote by date.")]
        public DateTime PS02007 { get; set; }

        [Display(Name = "Price By")]
        [Required(ErrorMessage = "Please enter Price by date.")]
        public DateTime PS02008 { get; set; }

        [Required(ErrorMessage = "Please select CS Person.")]
        [Display(Name = "CS Person")]
        public string PS02013 { get; set; }

        [Required(ErrorMessage = "Please select Procurement Person.")]
        [Display(Name = "Procurement Person")]
        public string PS02014 { get; set; }

        [Required(ErrorMessage = "Please select Sales Person.")]
        [Display(Name = "Sales Person")]
        public string PS02012 { get; set; }

        [Required(ErrorMessage = "Please select Team Lead.")]
        [Display(Name = "Team Lead")]
        public string PS02015 { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Please select order customer")]
        public string PS02003 { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Please select Invoice customer")]
        public string PS02004 { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Please select Delivery customer")]
        public string PS02005 { get; set; }


        [Display(Name = "Order Customer")]
        [StringLength(40)]
        public string PS02030 { get; set; }

        [Display(Name = "Address Part1")]
        [StringLength(40)]
        public string PS02031 { get; set; }

        [Display(Name = "Address Part2")]
        [StringLength(35)]
        public string PS02032 { get; set; }

        [Display(Name = "Address Part3")]
        [StringLength(35)]
        public string PS02033 { get; set; }



        [Display(Name = "Invoice Customer")]
        [StringLength(40)]
        public string PS02034 { get; set; }

        [Display(Name = "Address Part1")]
        [StringLength(40)]
        public string PS02035 { get; set; }

        [Display(Name = "Address Part2")]
        [StringLength(35)]
        public string PS02036 { get; set; }

        [Display(Name = "Address Part3")]
        [StringLength(35)]
        public string PS02037 { get; set; }



        [Display(Name = "Delivery Address")]
        [StringLength(40)]
        public string PS02023 { get; set; }

        [Display(Name = "Address Part1")]
        [StringLength(40)]
        public string PS02024 { get; set; }

        [Display(Name = "Address Part2")]
        [StringLength(35)]
        public string PS02025 { get; set; }

        [Display(Name = "Address Part3")]
        [StringLength(35)]
        public string PS02026 { get; set; }

        [Required(ErrorMessage = "Please select a POC")]
        [Display(Name = "Contact Person")]
        public string PS02017 { get; set; }


        [Display(Name = "Contact Number")]
        [StringLength(15)]
        public string PS02018 { get; set; }

        [Display(Name = "Customer Reference")]
        [StringLength(35)]
        [Required(ErrorMessage = "Please enter Customer Reference")]
        public string PS02019 { get; set; }

        [Display(Name = "Our Reference")]
        [StringLength(35)]
        public string PS02020 { get; set; }

        [Display(Name = "Currency")]
        [Required(ErrorMessage = "Please select a Currency")]
        public int PS02016 { get; set; }

        [Display(Name = "Payment Term")]
        [Required(ErrorMessage = "Please select a Payment Term")]
        public int PS02010 { get; set; }

        [Display(Name = "Reqd. Delivery Date")]
        public DateTime PS02009 { get; set; }

        [StringLength(25)]
        [Display(Name = "Lead Time")]
        public string PS02021 { get; set; }

        [Display(Name = "Delivery Location")]
        public int PS02039 { get; set; }


        [StringLength(100)]
        [Display(Name = "Remarks")]
        public string PS02022 { get; set; }

        public List<SelectListItem> CSPerson = new List<SelectListItem>();
        public List<SelectListItem> ProcurePerson = new List<SelectListItem>();
        public List<SelectListItem> SalesPerson = new List<SelectListItem>();
        public List<SelectListItem> TeamLead = new List<SelectListItem>();
        public List<SelectListItem> POC = new List<SelectListItem>();
        public List<SelectListItem> Currency = new List<SelectListItem>();
        public List<SelectListItem> PaymentTerm = new List<SelectListItem>();
        public List<SelectListItem> DelivLlocation = new List<SelectListItem>();




    }
}