﻿namespace DoggyBox.Data.Contracts
{
    using DoggyBox.Model;

    public interface IDataProvider
    {
        IGenericRepository<Trainer> Trainers { get; }

        IGenericRepository<Dog> Dogs { get; }

        IGenericRepository<Course> Courses { get; }

        IGenericRepository<ApplicationUser> ApplicationUsers { get; }

        IGenericRepository<Practice> Practices { get; }

        IGenericRepository<Mark> Marks { get; }

        IGenericRepository<Message> Messages { get; }

        IGenericRepository<CourseInfo> CoursesInfo { get; }

        IGenericRepository<Image> Images { get; }

        int SaveChanges();
    }
}
