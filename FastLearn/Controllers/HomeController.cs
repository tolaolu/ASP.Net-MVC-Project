using System.Web.Mvc;
using FastLearn.Context;
using FastLearn.Models;

namespace FastLearn.Controllers
{
    public class HomeController : Controller
    {
        private OperationDataContext context;
        public HomeController()
        {
            context = new OperationDataContext();
        }

        public ActionResult index()
        {
            return View();
        }
        // GET: Home
        public ActionResult Registration()
        {
            Registration model = new Registration();
            return View(model);
        }

        [HttpPost]
        public ActionResult Registration(Registration model)
        {
            try
            {
                Student std = new Student()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    Password = model.Password

                };
                context.Students.InsertOnSubmit(std);
                context.SubmitChanges();
                return RedirectToAction("index" , "Home");
            }
            catch
            {
                return View(model);
            }
        }

    }
}