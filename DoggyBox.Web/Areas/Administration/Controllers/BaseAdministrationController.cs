namespace DoggyBox.Web.Areas.Administration.Controllers
{
    using DoggyBox.Data.Contracts;
    using DoggyBox.Data.UnitsOfWork;
    using System.Web.Mvc;

    [Authorize(Roles = "Admin")]
    public class BaseAdministrationController : Controller
    {
        private IDataProvider data;

        public BaseAdministrationController()
            :this(new EFDataProvider())
        {
        }

        public BaseAdministrationController(IDataProvider data)
        {
            this.data = data;
        }

        protected IDataProvider Data { get { return this.data; } }
    }
}