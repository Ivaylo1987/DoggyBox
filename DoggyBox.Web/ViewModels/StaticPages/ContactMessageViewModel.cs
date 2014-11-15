namespace DoggyBox.Web.ViewModels.StaticPages
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using DoggyBox.Infrastructure.AutoMapper;
    using DoggyBox.Model;

    public class ContactMessageViewModel : IMapFrom<Message>
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string SenderEmail { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name = "Name")]
        public string SenderName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string SenderPhone { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name="Message")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}