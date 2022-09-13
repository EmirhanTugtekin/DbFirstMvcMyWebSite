using MyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class ExperienceController : Controller
    {
        PersonalDbEntities db = new PersonalDbEntities();
        // GET: Experience
        public ActionResult Index()
        {
            var values = db.TblExperience.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblExperience p)
        {
            db.TblExperience.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            var data = db.TblExperience.Where(x => x.ExperienceID == id).FirstOrDefault();
            db.TblExperience.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var data = db.TblExperience.Where(x => x.ExperienceID == id).FirstOrDefault();

            return View(data);
        }//sayfa yüklenince verileri getir
        [HttpPost]
        public ActionResult UpdateExperience(TblExperience p)
        {
            var data = db.TblExperience.Find(p.ExperienceID);
            data.ExperinceTitle = p.ExperinceTitle;
            data.ExperienceDescription = p.ExperienceDescription;
            data.ExperienceDate = p.ExperienceDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}