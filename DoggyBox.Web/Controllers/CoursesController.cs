using DoggyBox.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoggyBox.Web.Controllers
{
    public class CoursesController : BaseController
    {
        public CoursesController(IDataProvider provider)
            : base(provider)
        {
        }

        // GET: Courses
        public ActionResult ListAll()
        {
            return View();
        }
    }
}