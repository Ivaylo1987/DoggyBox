﻿namespace DoggyBox.Data
{
    using DoggyBox.Model;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DoggyBox", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, DoggyBox.Data.Migrations.Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Dog> Dogs { get; set; }
        public IDbSet<Trainer> Trainers { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<CourseInfo> CoursesInfo { get; set; }
        public IDbSet<Practice> Practices { get; set; }
        public IDbSet<Mark> Marks { get; set; }
        public IDbSet<Message> Messages { get; set; }
        public IDbSet<Image> Images { get; set; }
    }
}
