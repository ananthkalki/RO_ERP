using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalesApp.Models;

namespace SalesApp.Controllers
{
    public class FRTController : Controller
    {
        // GET: FRT
        public ActionResult Index()
        {
            FRTModel RM = new FRTModel();
            List<SelectListItem> delmeth = new List<SelectListItem>();
            delmeth.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            delmeth.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            delmeth.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.FRT3 = "370";
            RM.Delivery_Method = delmeth;

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
            RM.FRT4= "370";
            RM.Currency = currency;

            List<SelectListItem> vendor = new List<SelectListItem>();
            vendor.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            vendor.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            vendor.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.FRT5 = "370";
            RM.Vendor = vendor;

            List<SelectListItem> source = new List<SelectListItem>();
            source.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            source.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            source.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.FRT6 = "370";
            RM.Source = source;

            List<SelectListItem> destination = new List<SelectListItem>();
            destination.Add(new SelectListItem
            {
                Text = "Arjun",
                Value = "164"
            });
            destination.Add(new SelectListItem
            {
                Text = "Sreekanth",
                Value = "370"
            });
            destination.Add(new SelectListItem
            {
                Text = "Edwin",
                Value = "187"
            });
            RM.FRT7 = "370";
            RM.Destination = destination;

            return View(RM);
        }
    }
}