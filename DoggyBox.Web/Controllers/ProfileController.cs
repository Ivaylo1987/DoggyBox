namespace DoggyBox.Web.Controllers
{
    using AutoMapper.QueryableExtensions;
    using DoggyBox.Data.Contracts;
    using DoggyBox.Model;
    using DoggyBox.Web.ViewModels.Profile;
    using System;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;


    [Authorize]
    public class ProfileController : BaseController
    {
        public ProfileController(IDataProvider provider)
            : base(provider)
        {
        }

        public ActionResult Details()
        {
            var profile =
                this.Data.ApplicationUsers.All()
                .Where(x => x.Id == this.CurrentUser.Id)
                .Project().To<ProfileDetailsViewModel>()
                .FirstOrDefault();

            return this.View(profile);
        }

        public ActionResult Edit()
        {
            var profile =
                this.Data.ApplicationUsers.All().Where(x => x.Id == this.CurrentUser.Id)
                .Project().To<ProfileEditInputModel>()
                .FirstOrDefault();

            return this.View(profile);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProfileEditInputModel inputData)
        {
            if (inputData != null && ModelState.IsValid)
            {
                var profileToEdit = this.Data.ApplicationUsers.Find(this.CurrentUser.Id);

                profileToEdit.UserName = inputData.UserName;
                profileToEdit.Email = inputData.Email;
                profileToEdit.FirstName = inputData.FirstName;
                profileToEdit.LastName = inputData.LastName;
                profileToEdit.ContactPhone = inputData.ContactPhone;

                if (inputData.UploadedImage != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        inputData.UploadedImage.InputStream.CopyTo(memory);
                        var content = memory.GetBuffer();

                        profileToEdit.Image = new Image
                        {
                            Content = content,
                            FileExtension = inputData.UploadedImage.FileName.Split(new[] { '.' }).Last(),
                            CreatedOn = DateTime.Now
                        };
                    }
                }

                this.Data.SaveChanges();

                return this.RedirectToAction("Details");
            }

            return this.View(inputData);
        }

        public ActionResult GetImage(int id)
        {
            var image = this.Data.Images.Find(id);

            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            return this.File(image.Content, "image/" + image.FileExtension);
        }
    }
}