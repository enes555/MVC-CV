using MvcCv.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        GenericRepository<TBLSkill> repo = new GenericRepository<TBLSkill>();
        // GET: Yetenek
        public ActionResult Index()
        {
            var degerler = repo.List();

            return View(degerler);
            
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddSkill(TBLSkill t)
        {

            repo.TAdd(t);

            return View("Index");

        }
        public ActionResult DeleteSkill(int id)
        {
            TBLSkill t = repo.Find(x => x.ID == id);
            repo.TDelete(t);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            TBLSkill t = repo.Find(x => x.ID == id);
            return View(t);


        }

        [HttpPost]
        public ActionResult YetenekGetir(TBLSkill p)
        {
            TBLSkill t = repo.Find(x => x.ID == p.ID);
            t.ID = p.ID;
            t.Skill = p.Skill;
            t.oran = p.oran;
            t.acıklama = p.acıklama;
            repo.TUpdate(t);

            return RedirectToAction("Index");



        }

    }
}
