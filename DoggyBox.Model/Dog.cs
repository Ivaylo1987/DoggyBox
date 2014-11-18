namespace DoggyBox.Model
{
    using Application.Models.Base;
    using System;
    using System.Collections.Generic;

    public class Dog : AuditInfo
    {
        public Dog()
        {
            this.Courses = new HashSet<Course>();
            this.Marks = new HashSet<Mark>();
            this.Practices = new HashSet<Practice>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Breed { get; set; }

        public virtual ApplicationUser Owner { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }
    }
}
