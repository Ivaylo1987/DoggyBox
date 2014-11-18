namespace DoggyBox.Web.Areas.Administration.Models
{
    using Application.Models.Base;
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class CourseViewModel : AdministrationViewModel, IMapFrom<Course>
    {
        public int Id { get; set; }

    }
}