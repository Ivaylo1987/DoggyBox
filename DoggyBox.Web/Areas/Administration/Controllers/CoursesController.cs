namespace DoggyBox.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;

    using Kendo.Mvc.UI;

    using Model = DoggyBox.Model.Course;
    using ViewModel = DoggyBox.Web.Areas.Administration.Models.CourseViewModel;
    using DoggyBox.Data.Contracts;

    public class CoursesController : KendoGridAdministrationController
    {
        public CoursesController(IDataProvider data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            model.CreatedOn = DateTime.Now;
            var databaseModel = base.Create<Model>(model);

            if (databaseModel != null)
            {
                model.Id = databaseModel.Id;
            }

            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            base.Update<Model, ViewModel>(model, model.Id);
            return this.GridOperation(model, request);
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest]DataSourceRequest request, ViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                this.Data.Courses.Delete(model.Id);
                this.Data.SaveChanges();
            }

            return this.GridOperation(model, request);
        }

        protected override IEnumerable GetData()
        {
            var data = this.Data.Courses.All().Project().To<ViewModel>();
            return data;
        }

        protected override T GetById<T>(object id)
        {
            return this.Data.Courses.Find(id) as T;
        }
    }
}