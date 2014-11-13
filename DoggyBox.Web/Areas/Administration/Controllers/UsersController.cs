namespace DoggyBox.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    public class UsersController : BaseAdministrationController
    {
        // GET: Administration/Users
        public ActionResult ListAll()
        {
            return View();
        }
    }
}