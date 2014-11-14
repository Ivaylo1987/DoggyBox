using DoggyBox.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoggyBox.Web.Areas.Administration.Controllers
{
    public class HomeController : BaseAdministrationController
    {
        public HomeController(IDataProvider provider)
            : base(provider)
        {

        }

        // GET: Administration/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}