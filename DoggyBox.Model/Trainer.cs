namespace DoggyBox.Model
{
    using Application.Models.Base;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Trainer : AuditInfo
    {
        public Trainer()
        {
            this.Practices = new HashSet<Practice>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }
    }
}
