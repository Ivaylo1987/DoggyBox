namespace DoggyBox.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Trainer
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
