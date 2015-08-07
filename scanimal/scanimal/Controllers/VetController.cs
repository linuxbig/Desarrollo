using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scanimal.Controllers
{
    public class VetController : Controller
    {
        //
        // GET: /Vet/

        public ActionResult DashBoard()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }


    }
}
