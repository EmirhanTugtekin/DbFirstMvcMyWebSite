using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers
{
    public class SkillController : Controller
    {
        PersonalDbEntities db = new PersonalDbEntities();
        // GET: Skill
        public ActionResult Index()
        {
            var values = db.TblSkill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            db.TblSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var data=db.TblSkill.Where(x => x.SkillID == id).FirstOrDefault();
            db.TblSkill.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var data = db.TblSkill.Where(x => x.SkillID == id).FirstOrDefault();

            return View(data);
        }//sayfa yüklenince verileri getir
        [HttpPost]
        public ActionResult UpdateSkill(TblSkill p)
        {
            var data = db.TblSkill.Find(p.SkillID);
            data.SkillTitle = p.SkillTitle;
            data.SkillValue = p.SkillValue;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}