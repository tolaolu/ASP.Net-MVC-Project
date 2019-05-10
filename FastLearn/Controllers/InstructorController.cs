using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastLearn.Models;
using FastLearn.Context;

namespace FastLearn.Controllers
{
    public class InstructorController : Controller
    {
        private OperationDataContext context;
        public InstructorController()
        {
            context = new OperationDataContext();
        }
        // GET: Admin
        public ActionResult _instruct()
        {
            IList<GetInstructor> studentlist = new List<GetInstructor>();
            var query = from std in context.Instructors
                        select std;
            var students = query.ToList();
            foreach (var studentData in students)
            {
                studentlist.Add(new GetInstructor()
                {
                    //FacultyId = studentData.FacultyId,
                    FName = studentData.FName,
                    FAddress = studentData.FAddress
                });
            }
            return View(studentlist);
        }
    }
}