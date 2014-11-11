namespace DoggyBox.Model
{
    using System;
    using System.Collections.Generic;

    public class TrainingPractice
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}