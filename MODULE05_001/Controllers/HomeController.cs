using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODULE05_001.Controllers
{
    //[HandleError(View = "AA")] 
    public class HomeController : Controller
    {
        // GET: Home ^^
        public ActionResult Index()
        {
            return View();
        }

        //Web.config ==> <customErrors mode="On"></customErrors>
        //[HandleError]
        public ActionResult ExceptionDemo()
        {
            int i = 0;
            int j = 10 / i;

            return View();
        }
    }
}