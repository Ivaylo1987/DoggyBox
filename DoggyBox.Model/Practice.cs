namespace DoggyBox.Model
{
    using System;
    using System.Collections.Generic;

    public class Practice
    {
        public Practice()
        {
            this.Courses = new HashSet<Course>();
            this.Trainers = new HashSet<Trainer>();
            this.Dogs = new HashSet<Dog>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Dog> Dogs { get; set; }
    }
}