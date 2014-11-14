namespace DoggyBox.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Message
    {
        public int Id { get; set; }

        [Required]
        public string SenderName { get; set; }

        [Required]
        [EmailAddress]
        public string From { get; set; }

        public string To { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
