using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeleDermUI.Areas.Reader.Controllers
{
    public class ConsultController : Controller
    {
        //
        // GET: /Reader/Consult/

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Update(BOL.Telederm_Consult objConsult )
        {

            return View();
        }
    }
}
