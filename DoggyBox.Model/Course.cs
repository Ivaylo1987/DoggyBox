namespace DoggyBox.Model
{
    using System.Collections.Generic;

    public class Course
    {
        public Course()
        {
            this.Practices = new HashSet<Practice>();
            this.Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
