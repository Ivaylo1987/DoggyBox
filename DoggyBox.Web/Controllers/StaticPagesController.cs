namespace DoggyBox.Web.Controllers
{
    using AutoMapper;
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

            var dbMessage = Mapper.Map<Message>(sentMessage);

            dbMessage.ReceiverEmail = "support@doggybox.com";

            this.Data.Messages.Add(dbMessage);
            this.Data.SaveChanges();

            this.TempData["successMessage"] = "Your message was successfully sent!";

            return RedirectToAction("Contact");
        }
    }
}