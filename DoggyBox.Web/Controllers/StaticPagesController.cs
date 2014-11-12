namespace DoggyBox.Web.Controllers
{
    using DoggyBox.Web.ViewModels.StaticPages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class StaticPagesController : BaseController
    {
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactMessageViewModel message)
        {
            var isModelStateValid = ModelState.IsValid;
            
            return View();
        }
    }
}