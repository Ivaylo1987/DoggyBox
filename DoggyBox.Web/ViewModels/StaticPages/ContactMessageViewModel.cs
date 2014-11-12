namespace DoggyBox.Web.ViewModels.StaticPages
{
    using System.ComponentModel.DataAnnotations;

    public class ContactMessageViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        public string MessageText { get; set; }
    }
}