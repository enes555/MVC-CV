using MvcCv.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;



namespace MvcCv.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        GenericRepository<TBLExperiences> repo = new GenericRepository<TBLExperiences>();

        public ActionResult Index()
        {

            var degerler = repo.List();

            return View(degerler);
        }
    }
}