namespace DoggyBox.Web.ViewModels.Courses
{
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;
    using System.ComponentModel.DataAnnotations;

    public class TrainerViewModel : IMapFrom<Trainer>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}