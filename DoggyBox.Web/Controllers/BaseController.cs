namespace DoggyBox.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DoggyBox.Data.UnitsOfWork;
    using DoggyBox.Data.Contracts;

    public class BaseController : Controller
    {

        public BaseController()
            : this(new EFDataProvider())
        {
        }

        public BaseController(IDataProvider data)
        {
            this.Data = data;
        }

        protected IDataProvider Data { get; set; }
    }
}