namespace DoggyBox.Model
{
    using Application.Models.Base;
    using System.Collections.Generic;

    public class Course : AuditInfo
    {
        public Course()
        {
            this.Practices = new HashSet<Practice>();
            this.Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }

        public CourseStatus Status { get; set; }

        public CourseInfo Info { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
