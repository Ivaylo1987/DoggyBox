namespace DoggyBox.Model
{
    using Application.Models.Base;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Message : AuditInfo
    {
        public int Id { get; set; }

        [Required]
        public string SenderName { get; set; }

        [Required]
        [EmailAddress]
        public string SenderEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string SenderPhone { get; set; }

        public string ReceiverEmail { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
