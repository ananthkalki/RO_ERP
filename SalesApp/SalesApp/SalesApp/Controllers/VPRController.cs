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
            RM.CSPerson = items;
            List<SelectListItem> Proc = new List<SelectListItem>();
            Proc.Add(new SelectListItem
            {
                Text = "Prasad",
                Value = "135"
            });
            Proc.Add(new SelectListItem
            {
                Text = "Gowri",
                Value = "320"
            });
            Proc.Add(new SelectListItem
            {
                Text = "Rejow",
                Value = "280"
            });
            RM.ProcurePerson = Proc;
            List<SelectListItem> Sales = new List<SelectListItem>();
            Sales.Add(new SelectListItem
            {
                Text = "Ashwin",
                Value = "208"
            });
            Sales.Add(new SelectListItem
            {
                Text = "Anjali",
                Value = "312"
            });
            Sales.Add(new SelectListItem
            {
                Text = "Bibin",
                Value = "255"
            });
            RM.SalesPerson = Sales;

            List<SelectListItem> TL = new List<SelectListItem>();
            TL.Add(new SelectListItem
            {
                Text = "Rejoe",
                Value = "208"
            });
            TL.Add(new SelectListItem
            {
                Text = "Gowri",
                Value = "312"
            });
            TL.Add(new SelectListItem
            {
                Text = "Ebin",
                Value = "255"
            });
            RM.TeamLead = TL;
            RM.PS02006 = DateTime.Now;
            RM.PS02007 = DateTime.Now.AddHours(48);
            RM.PS02008 = DateTime.Now.AddHours(48);
            return View(RM);

        }
    }
}