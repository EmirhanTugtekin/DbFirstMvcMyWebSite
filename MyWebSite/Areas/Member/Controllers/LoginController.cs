using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyWebSite.Models;

namespace MyWebSite.Areas.Member.Controllers
{
    public class LoginController : Controller
    {
        PersonalDbEntities db = new PersonalDbEntities();
        // GET: Member/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblMember p)
        {
            var values = db.TblMember.FirstOrDefault(x=>x.MemberMail==p.MemberMail && x.MemberPassword==p.MemberPassword);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.MemberMail, false);//true olursa her defasında tekrar girilir veya opsiyonel yapılabilir, böylece kullanıcı "beni hatırla" tikini seçtiyse tekrar girerken tekrar şifre vs girmesine gerek kalmaz

                Session["MemberMail"] = values.MemberMail;//oturum adı memberMail olsun ve values'in MemberMail'ini alsın
                return RedirectToAction("Index","Profile");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}