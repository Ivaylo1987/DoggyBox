﻿namespace DoggyBox.Data.UnitsOfWork
{

    using Application.Models.Base;
    using DoggyBox.Data.Contracts;
    using DoggyBox.Data.Repositories;
    using DoggyBox.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EFDataProvider : IDataProvider
    {
        private ApplicationDbContext context;
        private IDictionary<Type, object> repositories;

        public EFDataProvider(ApplicationDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Trainer> Trainers
        { 
            get
            {
                return this.GetRepository<Trainer>();
            }
        }

        public IGenericRepository<Dog> Dogs
        {
            get
            {
                return this.GetRepository<Dog>();
            }
        }

        public IGenericRepository<Image> Images
        {
            get
            {
                return this.GetRepository<Image>();
            }
        }

        public IGenericRepository<Course> Courses
        {
            get
            {
                return this.GetRepository<Course>();
            }
        }

        public IGenericRepository<CourseInfo> CoursesInfo
        {
            get
            {
                return this.GetRepository<CourseInfo>();
            }
        }

        public IGenericRepository<ApplicationUser> ApplicationUsers
        {
            get
            {
                return this.GetRepository<ApplicationUser>();
            }
        }

        public IGenericRepository<Practice> Practices
        {
            get
            {
                return this.GetRepository<Practice>();
            }
        }

        public IGenericRepository<Mark> Marks
        {
            get
            {
                return this.GetRepository<Mark>();
            }
        }

        public IGenericRepository<Message> Messages
        {
            get
            {
                return this.GetRepository<Message>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public ApplicationDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class, IAuditInfo
        {
            var typeOfModel = typeof(T);

            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericEFRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
