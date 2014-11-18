using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoggyBox.Data.Contracts;

namespace DoggyBox.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IDataProvider provider)
            :base(provider)
        {
        }

        [OutputCache(Duration= 20)]
        public ActionResult Index()
        {
            return View();
        }
    }
}