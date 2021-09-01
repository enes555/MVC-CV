using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLUser p)
        {
            DbCvEntities db = new DbCvEntities();
            var inf = db.TBLUser.FirstOrDefault(x => x.UserName ==p.UserName && x.Password==p.Password);

            if (inf != null)
            {
                FormsAuthentication.SetAuthCookie(inf.UserName, false);
                Session["Username"] = inf.UserName.ToString();
                return RedirectToAction("Index", "Education");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

    }
}