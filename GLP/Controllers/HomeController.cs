using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GLP.Models;

namespace GLP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewTestTable view = new ViewTestTable();
            view.viewTestTable = new TestTable().getTestTable();
            return View(view);
        }
    }
}