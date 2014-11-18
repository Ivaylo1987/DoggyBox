namespace DoggyBox.Model
{
    using Application.Models.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Practice : AuditInfo
    {
        public Practice()
        {
            this.Courses = new HashSet<Course>();
            this.Trainers = new HashSet<Trainer>();
            this.Dogs = new HashSet<Dog>();
        }

        public int Id { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime Date { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Dog> Dogs { get; set; }
    }
}