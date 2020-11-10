using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesApp.Models;

namespace SalesApp.Controllers
{
    public class PMController : Controller
    {
        // GET: PM
        public ActionResult Index()
        {
            PMModel RM = new PMModel();

            List<SelectListItem> currency = new List<SelectListItem>();
            currency.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            currency.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            currency.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.PM3 = "370";
            RM.Currency = currency;

            List<SelectListItem> logo = new List<SelectListItem>();
            logo.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            logo.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            logo.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.PM6 = "370";
            RM.Logo = logo;

            List<SelectListItem> incoterm = new List<SelectListItem>();
            incoterm.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            incoterm.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            incoterm.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.PM9 = "370";
            RM.Incoterm = incoterm;

            return View(RM);
        }
    }
}