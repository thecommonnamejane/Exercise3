using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        DBEntities db = new DBEntities();

        // --------------------------------------------------------------------

        public ActionResult Index()
        {
            return View();
        }

        // --------------------------------------------------------------------

        public ActionResult Demo1()
        {
            return View();
        }

        // --------------------------------------------------------------------

        private SelectList GetMonthList()
        {
            // TODO: Return January to Decemeber


            return new SelectList(new[] { "TODO" });
        }

        private SelectList GetYearList(int min, int max, bool reverse = false)
        {
            // TODO: Return min to max years
            

            return new SelectList(new[] { "TODO" });
        }

        public ActionResult Demo2(int month = 0, int year = 0)
        {
            ViewBag.MonthList = GetMonthList();
            ViewBag.YearList  = GetYearList(DateTime.Today.Year - 4, DateTime.Today.Year, true);

            if (month == 0) month = DateTime.Today.Month;
            if (year  == 0) year  = DateTime.Today.Year;
            
            ViewBag.Month = month;
            ViewBag.Year  = year;
            
            return View();
        }

        // --------------------------------------------------------------------

        public ActionResult Demo3()
        {
            // TODO: Default to today's date
            

            return View();
        }

        [HttpPost]
        public ActionResult Demo3(Event model)
        {
            if (ModelState.IsValidField("Date"))
            {
                // TODO: Server-side custom validation for date
                //       Range: 30 days before and 30 days after today
                
                
            }

            if (ModelState.IsValid)
            {
                db.Events.Add(model);
                db.SaveChanges();

                TempData["success"] = $"Event #{model.Id} {model.Name} added on {model.Date.ToString("yyyy-MM-dd")}.";
                return RedirectToAction(null);
            }

            return View();
        }

        // --------------------------------------------------------------------

        public ActionResult Demo4()
        {
            var model = db.Events;
            return View(model);
        }

        // --------------------------------------------------------------------
        
        private int ImportEvents(System.IO.Stream stream)
        {
            // TODO: Read from stream --> import events
            

            return db.SaveChanges();
        }

        [HttpPost]
        public ActionResult Import(HttpPostedFileBase file)
        {
            var reName = new Regex(@".+\.txt", RegexOptions.IgnoreCase);
            var reType = new Regex(@"text\/plain", RegexOptions.IgnoreCase);
            
            if (file != null &&
                reName.IsMatch(file.FileName) &&
                reType.IsMatch(file.ContentType))
            {
                int n = ImportEvents(file.InputStream);
                TempData["success"] = $"{n} events imported.";
            }

            return Redirect(Request.UrlReferrer.AbsolutePath);
        }

        [HttpPost]
        public ActionResult Truncate()
        {
            // TODO: Use TRUNCATE
            db.Events.RemoveRange(db.Events);
            db.SaveChanges();
            
            TempData["warning"] = "Events truncated.";
            return Redirect(Request.UrlReferrer.AbsolutePath);
        }

        // --------------------------------------------------------------------

        public ActionResult Demo5()
        {
            // TODO: Return events, group by date
            var model = db.Events;
            return View(model);
        }

        // --------------------------------------------------------------------

        

        public ActionResult Demo6(int month = 0, int year = 0)
        {
            int min = DateTime.Today.Year;
            int max = DateTime.Today.Year;

            // TODO: If there are events, update the min and max
                

            ViewBag.MonthList = GetMonthList();
            ViewBag.YearList  = GetYearList(min, max);

            if (month == 0) month = DateTime.Today.Month;
            if (year  == 0) year  = DateTime.Today.Year;
            
            ViewBag.Month = month;
            ViewBag.Year  = year;

            // ==================================
            // TODO: Working with dictionary
            // ==================================

            
            return View();
        }

    }
}