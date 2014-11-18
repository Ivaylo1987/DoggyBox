namespace DoggyBox.Model
{
    using System.Collections.Generic;
    using Application.Models.Base;

    public class CourseInfo : AuditInfo
    {

        public CourseInfo()
        {
            this.Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
