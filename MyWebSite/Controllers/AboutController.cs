using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;
namespace MyWebSite.Controllers
{
    public class AboutController : Controller
    {
        PersonalDbEntities db = new PersonalDbEntities();
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult StatisticPartial()
        {
            ViewBag.v1 = db.TblSkill.Count();//yetenek sayısı
            ViewBag.v2 = db.TblImage.Where(x=>x.Category=="C#").Count();//kategorisi c# olan foto sayısı

            int id=db.TblExperience.Max(x => x.ExperienceID);
            ViewBag.v3 = db.TblExperience.Where(x => x.ExperienceID == id).Select(y => y.ExperinceTitle).FirstOrDefault();
            //son çalışılan firmanın adı

            ViewBag.v4 = db.TblExperience.Where(x => x.ExperinceTitle == "Eğitmen").Count();//eğitmen olarak yapılan tecrübe sayısı

            return PartialView();
        }
    }
}