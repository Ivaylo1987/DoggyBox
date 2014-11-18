namespace DoggyBox.Web.Areas.Administration.Models
{
    using Application.Models.Base;
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class UserViewModel : AdministrationViewModel, IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public ICollection<DogViewModel> Dogs { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(m => m.Dogs, opt => opt.MapFrom(u => u.Dogs));
        }
    }
}