using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        // GET: Default
        public ActionResult Index()
        {
            var values = db.TBLAbout.ToList();

            return View(values);
        }
        public PartialViewResult Experience()
        {
            var values = db.TBLExperiences.ToList();
            return PartialView(values);

        }
        public PartialViewResult Education()
        {
            var values = db.TBLEducation.ToList();
            return PartialView(values);
        }
        public PartialViewResult Skills()
        {
            var values = db.TBLSkill.ToList();
            return PartialView(values);

        }
        public PartialViewResult Hobbies()
        {
            var values = db.TBLHobbies.ToList();
            return PartialView(values);

        }
        public PartialViewResult Sertificates()
        {
            var values = db.TBLSertificates.ToList();
            return PartialView(values);

        }
        [HttpGet]
        public PartialViewResult Comminication()
        {
            var values = db.TBLCommunication.ToList();
            return PartialView(values);
        }
        [HttpPost]
        public PartialViewResult Comminication(TBLCommunication c)
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLCommunication.Add(c);
            db.SaveChanges();
            return PartialView();
        }
        public PartialViewResult Profil()
        {
            var values = db.TBLAbout.ToList();
            return PartialView(values);

        }


    }
}