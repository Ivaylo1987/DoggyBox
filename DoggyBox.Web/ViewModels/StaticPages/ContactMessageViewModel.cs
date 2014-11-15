namespace DoggyBox.Web.ViewModels.StaticPages
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ContactMessageViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [AllowHtml]
        public string Name { get; set; }

        public string Phone { get; set; }

        [Display(Name="Message")]
        [AllowHtml]
        public string Content { get; set; }
    }
}