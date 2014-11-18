namespace DoggyBox.Web.ViewModels.Courses
{
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;

    public class CourseInfoViewModel : IMapFrom<CourseInfo>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}