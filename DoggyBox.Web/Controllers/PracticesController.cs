namespace DoggyBox.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;
    using System.Web;
    using DoggyBox.Data.Contracts;

    public class PracticesController : BaseController
    {
        public PracticesController(IDataProvider data)
            : base(data)
        {

        }

        [Authorize]
        public ActionResult Join(int id)
        {
            var practice = this.Data.Practices.All().FirstOrDefault( p => p.Id == id);

            if (practice == null)
            {
                throw new HttpException(404, "Practice not found");
            }

            if (practice.Dogs.Where(d => d.Owner != null).Any(d => d.Owner.Id == this.CurrentUser.Id))
            {
                throw new HttpException(400, "Bad reqest already joined!");
            }
            var userId = this.CurrentUser.Id;

            var currentDogs = this.Data.Dogs.All().Where(d => d.Owner.Id == userId);

            foreach (var dog in currentDogs)
            {
                practice.Dogs.Add(dog);
            }

            this.Data.SaveChanges();

            return RedirectToAction("ListAllActive", "Courses");
        }
    }
}