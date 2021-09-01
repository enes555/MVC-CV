using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repository;
namespace MvcCv.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<TBLEducation> repo = new GenericRepository<TBLEducation>();
        // GET: Education


        public ActionResult Index()
        {
            var degerler = repo.List();

            return View(degerler);

        }
        [HttpGet]
        public ActionResult AddEducation()
        {

            return View();

        }
        [HttpPost]
        public ActionResult AddEducation(TBLEducation t)
        {

            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            repo.TAdd(t);

            return View("Index");

        }
        public ActionResult DeleteEducation(int id)
        {
            TBLEducation t = repo.Find(x => x.ID == id);
            repo.TDelete(t);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult EğitimGetir(int id)
        {
            TBLEducation t = repo.Find(x => x.ID == id);
            return View(t);


        }

        [HttpPost]
        public ActionResult EğitimGetir(TBLEducation p)
        {
            TBLEducation t = repo.Find(x => x.ID == p.ID);
            t.ID = p.ID;
            t.Title = p.Title;
            t.subtitle = p.subtitle;
            t.subtitle2 = p.subtitle2;
            t.GNO = p.GNO;

            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            repo.TUpdate(t);

            return RedirectToAction("Index");



        }
    }
}