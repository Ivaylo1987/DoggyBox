namespace DoggyBox.Web.ViewModels.Courses
{
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;

    public class DogViewModel : IMapFrom<Dog>
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}