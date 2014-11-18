namespace DoggyBox.Web.Areas.Administration.Models
{
    using Application.Models.Base;
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class CourseViewModel : AdministrationViewModel, IMapFrom<Course>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public void CreateMappings(AutoMapper.IConfiguration configuration)
        {
            configuration.CreateMap<Course, CourseViewModel>()
                .ForMember(m => m.Name, opt => opt.MapFrom(u => u.Info.Name))
                .ForMember(m => m.Description, opt => opt.MapFrom(u => u.Info.Description))
                .ForMember(m => m.Status, opt => opt.MapFrom(u => u.Status.ToString()));
        }
    }
}