using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastLearn.Models;
using FastLearn.Context;

namespace FastLearn.Controllers
{
    public class AdminController : Controller
    {
        private OperationDataContext context;
  public AdminController()
        {
            context = new OperationDataContext();
        }
        // GET: Admin
        public ActionResult index()
        {
            IList<Registration> studentlist = new List<Registration>();
            var query = from std in context.Students
                        select std;
            var students = query.ToList();
            foreach (var studentData in students)
            {
                studentlist.Add(new Registration()
                {
                    Name = studentData.Name,
                    Email = studentData.Email,
                    Address = studentData.Address,
                     Phone = studentData.Phone
                });
            }
            return View(studentlist);
        }

        /*public ActionResult _instruct()
        {
            IList<instructor> studentlist = new List<instructor>();
            var query = from std in context.Instructors
                        select std;
            var students = query.ToList();
            foreach (var studentData in students)
            {
                studentlist.Add(new instructor()
                {
                    FName = studentData.FName,
                FAddress   = studentData.FAddress,
                 });
            }
            return View(studentlist);
        }
*/
    }
}