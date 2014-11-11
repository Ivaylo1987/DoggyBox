namespace DoggyBox.Model
{
    using System;
    using System.Collections.Generic;

    public class Dog
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

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }

    }
}
