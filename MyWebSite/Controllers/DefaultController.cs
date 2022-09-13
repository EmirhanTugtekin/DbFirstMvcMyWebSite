using MyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace MyWebSite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        PersonalDbEntities db=new PersonalDbEntities(); 
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult BannerPartial()
        {
            return PartialView();
        }
        public PartialViewResult SkillPartial()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }
        public PartialViewResult ImagePartial()
        {
            ViewBag.v = "mvc";
            var values = db.TblImage.ToList();
            return PartialView(values);
        }
        public PartialViewResult ExperiencePartial()
        {
            return PartialView();
        }
        public PartialViewResult EducationPartial()
        {
            return PartialView();
        }
        public PartialViewResult TestimonalPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}