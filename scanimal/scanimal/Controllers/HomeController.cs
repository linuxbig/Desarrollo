using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scanimal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Login()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }


        public ActionResult LoginVerify()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Registro()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Registro2()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult RegistroVerify()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Registro3()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Registro4()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Registro5()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }


        public ActionResult RegistroEnd()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }
        
        public ActionResult About()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Contact()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }
    }
}
