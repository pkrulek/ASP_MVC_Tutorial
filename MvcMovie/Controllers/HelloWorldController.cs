using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index(string name, int id)
        {
            return HttpUtility.HtmlEncode(String.Format("Hello {0}, ID: {1}", name, id));
        }

        public string Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method.";
            return HttpUtility.HtmlEncode(String.Format("Hello {0}, Num Times: {1}", name, numTimes));
        }
    }
}