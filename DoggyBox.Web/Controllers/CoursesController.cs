namespace DoggyBox.Web.Controllers
{
    using AutoMapper.QueryableExtensions;
    using DoggyBox.Data.Contracts;
    using DoggyBox.Model;
    using DoggyBox.Web.ViewModels.Courses;
    using System.Linq;
    using System.Web.Mvc;

    public class CoursesController : BaseController
    {
        public CoursesController(IDataProvider provider)
            : base(provider)
        {
        }

        // GET: Courses
        public ActionResult ListAllActive()
        {
            var onpoingCourses = this.Data.Courses.All()
                             .Where(c => c.Status == CourseStatus.Ongoing)
                             .Project().To<CourseViewModel>();

            return View(onpoingCourses);
        }
    }
}