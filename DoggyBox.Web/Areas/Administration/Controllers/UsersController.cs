namespace DoggyBox.Web.Areas.Administration.Controllers
{
    using DoggyBox.Data.Contracts;
using System.Web.Mvc;

    public class UsersController : BaseAdministrationController
    {
        public UsersController(IDataProvider provider)
            :base(provider)
        {

        }

        // GET: Administration/Users
        public ActionResult ListAll()
        {
            return View();
        }
    }
}