namespace DoggyBox.Web.ViewModels.Profile
{
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using DoggyBox.Web.ViewModels.Courses;
    using System;
    using System.Collections.Generic;

    public class ProfileDetailsViewModel : IMapFrom<ApplicationUser>
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactPhone { get; set; }

        public int? ImageId { get; set; }

        public virtual ICollection<DogViewModel> Dogs { get; set; }
    }
}