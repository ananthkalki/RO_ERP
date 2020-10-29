using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesApp.Models;

namespace SalesApp.Controllers
{
    public class VPRController : Controller
    {
        // GET: VPR
        public ActionResult Index()
        {
            VPRModel RM = new VPRModel();
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            items.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            items.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.PS02013 = "370";
            RM.Vendor = items;
                 
            return View(RM);

        }
    }
}