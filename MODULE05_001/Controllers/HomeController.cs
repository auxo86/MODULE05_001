using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MODULE05_001.Controllers
{
    //用AA.cshtml自訂錯誤網頁，範圍是全controller
    //[HandleError(View = "AA")] 
    public class HomeController : Controller
    {
        // GET: Home ^^
        public ActionResult Index()
        {
            return View();
        }

        //Web.config ==> <customErrors mode="On"></customErrors>
        //上面這行一定要啟用，否則沒有自訂除錯的功能
        //下面這個標籤限定只有這個action有自訂除錯顯示，上面的index 出錯可沒人理了。然後Shared資料夾是固定的，Error.cshtml則是固定的除錯訊息顯示頁
        //[HandleError]
        public ActionResult ExceptionDemo()
        {
            int i = 0;
            int j = 10 / i;

            return View();
        }
    }
}