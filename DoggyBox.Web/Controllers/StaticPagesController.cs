namespace DoggyBox.Web.Controllers
{
    using DoggyBox.Data.Contracts;
    using DoggyBox.Model;
    using DoggyBox.Web.ViewModels.StaticPages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class StaticPagesController : BaseController
    {
        public StaticPagesController(IDataProvider provider)
            : base(provider)
        {
        }

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
        public ActionResult Contact(ContactMessageViewModel sentMessage)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var isAjax = this.Request.IsAjaxRequest();

            var dbMessage = new Message
            {
                Content = sentMessage.Content,
                From = sentMessage.Email,
                SenderName = sentMessage.Name,
                To = "support@doggybox.com",
                Date = DateTime.Now
            };

            this.Data.Messages.Add(dbMessage);
            this.Data.SaveChanges();

            this.TempData["successMessage"] = "Your message was successfully sent!";

            return RedirectToAction("Contact");
        }

        public ActionResult Courses()
        {
            return View();
        }
    }
}