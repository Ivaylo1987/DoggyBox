namespace DoggyBox.Web.ViewModels.Courses
{
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System.Collections.Generic;

    public class CourseViewModel : IMapFrom<Course>
    {
        public CourseInfoViewModel Info { get; set; }

        public virtual ICollection<PracticeViewModel> Practices { get; set; }
    }
}