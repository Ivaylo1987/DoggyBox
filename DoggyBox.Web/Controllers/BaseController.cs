namespace DoggyBox.Web.Controllers
{
    using DoggyBox.Data.Contracts;
    using DoggyBox.Model;
    using Microsoft.AspNet.Identity;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        private ApplicationUser currentUser;

        public BaseController(IDataProvider data)
        {
            this.Data = data;
        }

        protected IDataProvider Data { get; set; }

        public ApplicationUser CurrentUser
        {
            get
            {
                if (this.currentUser == null)
                {
                    var currentUserId = User.Identity.GetUserId();
                    this.currentUser = this.Data.ApplicationUsers.Find(currentUserId);
                }

                return this.currentUser;
            }
        }
    }
}