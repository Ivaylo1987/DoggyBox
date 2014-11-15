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

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name="Message")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}