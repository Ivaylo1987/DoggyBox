namespace DoggyBox.Web.ViewModels.Profile
{
    using AutoMapper;
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public class ProfileEditInputModel : IMapFrom<ApplicationUser>
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }

        [Display(Name = "Profile Photo")]
        public HttpPostedFileBase UploadedImage { get; set; }
    }
}