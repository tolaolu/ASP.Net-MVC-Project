using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastLearn.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult index()
        {
            return View();
        }
    }
}