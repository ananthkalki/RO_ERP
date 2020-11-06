using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesApp.Models;

namespace SalesApp.Controllers
{
    public class VPDController : Controller
    {
        // GET: VPD
        public ActionResult Index()
        {
            VPDModel RM = new VPDModel();
            List<SelectListItem> items = new List<SelectListItem>();
            List<SelectListItem> currency = new List<SelectListItem>();
            items.Add(new SelectListItem
            {
                Text = "dummy1",
                Value = "164"
            });
            items.Add(new SelectListItem
            {
                Text = "dummy2",
                Value = "370"
            });
            items.Add(new SelectListItem
            {
                Text = "dummy3",
                Value = "187"
            });
            RM.PS02013 = "370";
            RM.Vendor = items;
            currency.Add(new SelectListItem
            {
                Text = "dummy1",
                Value = "164"
            });
            currency.Add(new SelectListItem
            {
                Text = "dummy2",
                Value = "370"
            });
            currency.Add(new SelectListItem
            {
                Text = "dummy3",
                Value = "187"
            });
            RM.vpd2 = "370";
            RM.Currency = currency;
          

            return View(RM);

        }
    }
}