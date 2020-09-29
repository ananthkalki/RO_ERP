using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesApp.Models
{
    public class RFQModel
    {
        [Display(Name = "RFQ Number")]
        [StringLength(10)]
        public string PS01001 { get; set; }
        [Display(Name = "RFQ Date")]
        [Required(ErrorMessage = "Please enter RFQ date.")]
        public DateTime PS01006 { get; set; }

        [Display(Name = "Quote By")]
        [Required(ErrorMessage = "Please enter Quote by date.")]
        public DateTime PS01007 { get; set; }

        [Display(Name = "Price By")]
        [Required(ErrorMessage = "Please enter Price by date.")]
        public DateTime PS01008 { get; set; }

        [Required(ErrorMessage = "Please select CS Person.")]
        [Display(Name = "CS Person")]
        public string PS01013 { get; set; }

        [Required(ErrorMessage = "Please select Procurement Person.")]
        [Display(Name = "Procurement Person")]
        public string PS01014 { get; set; }

        [Required(ErrorMessage = "Please select Sales Person.")]
        [Display(Name = "Sales Person")]
        public string PS01012 { get; set; }

        [Required(ErrorMessage = "Please select Team Lead.")]
        [Display(Name = "Team Lead")]
        public string PS01015 { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Please select order customer")]
        public string PS01003 { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Please select Invoice customer")]
        public string PS01004 { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Please select Delivery customer")]
        public string PS01005 { get; set; }


        [Display(Name = "Order Customer")]
        [StringLength(40)]
        public string PS01030 { get; set; }

        [Display(Name = "Address Part1")]
        [StringLength(40)]
        public string PS01031 { get; set; }

        [Display(Name = "Address Part2")]
        [StringLength(35)]
        public string PS01032 { get; set; }

        [Display(Name = "Address Part3")]
        [StringLength(35)]
        public string PS01033 { get; set; }



        [Display(Name = "Invoice Customer")]
        [StringLength(40)]
        public string PS01034 { get; set; }

        [Display(Name = "Address Part1")]
        [StringLength(40)]
        public string PS01035 { get; set; }

        [Display(Name = "Address Part2")]
        [StringLength(35)]
        public string PS01036 { get; set; }

        [Display(Name = "Address Part3")]
        [StringLength(35)]
        public string PS01037 { get; set; }



        [Display(Name = "Delivery Address")]
        [StringLength(40)]
        public string PS01023 { get; set; }

        [Display(Name = "Address Part1")]
        [StringLength(40)]
        public string PS01024 { get; set; }

        [Display(Name = "Address Part2")]
        [StringLength(35)]
        public string PS01025 { get; set; }

        [Display(Name = "Address Part3")]
        [StringLength(35)]
        public string PS01026 { get; set; }

        [Required(ErrorMessage = "Please select a POC")]
        [Display(Name = "Contact Person")]
        public string PS01017 { get; set; }


        [Display(Name = "Contact Number")]
        [StringLength(15)]
        public string PS01018 { get; set; }

        [Display(Name = "Customer Reference")]
        [StringLength(35)]
        [Required(ErrorMessage = "Please enter Customer Reference")]
        public string PS01019 { get; set; }

        [Display(Name = "Our Reference")]
        [StringLength(35)]
        public string PS01020 { get; set; }

        [Display(Name = "Currency")]
        [Required(ErrorMessage = "Please select a Currency")]
        public int PS01016 { get; set; }

        [Display(Name = "Payment Term")]
        [Required(ErrorMessage = "Please select a Payment Term")]
        public int PS01010 { get; set; }

        [Display(Name = "Reqd. Delivery Date")]
        public DateTime PS01009 { get; set; }

        [StringLength(25)]
        [Display(Name = "Lead Time")]
        public string PS01021 { get; set; }

        [Display(Name = "Delivery Location")]
        public int PS01039 { get; set; }


        [StringLength(100)]
        [Display(Name = "Remarks")]
        public string PS01022 { get; set; }

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