namespace DoggyBox.Data.Migrations.Seeders
{
    using DoggyBox.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CoursesSeeder
    {
        public static void Seed(ApplicationDbContext databaseContext)
        {
            if (!databaseContext.Courses.Any())
            {
                var dogs = new List<Dog>()
                {
                    new Dog()
                    {
                        Name= "Sparky",
                        Breed = "Bulldog",
                        DateOfBirth = new DateTime(2013, 11, 2),

                    },
                    new Dog()
                    {
                        Name= "Balkan",
                        Breed = "Mix",
                        DateOfBirth = new DateTime(2014, 2, 10),
                    },
                    new Dog()
                    {
                        Name= "Holly",
                        Breed = "Pomeran",
                        DateOfBirth = new DateTime(2014, 7, 1),
                    },new Dog()
                    {
                        Name= "Dara",
                        Breed = "German Shephard",
                        DateOfBirth = new DateTime(2011, 3, 8),
                    },
                    new Dog()
                    {
                        Name= "Joko",
                        Breed = "Jack Russel Terrier",
                        DateOfBirth = new DateTime(2012, 8, 21),
                    }
                };

                var trainers = new List<Trainer>()
                {
                    new Trainer()
                    {
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    new Trainer()
                    {
                        FirstName = "Ann",
                        LastName = "Doe"
                    }
                };

                var practices = new List<Practice>()
                {
                    new Practice()
                    {
                        Date = new DateTime(2014, 12, 10),
                        Trainers = new List<Trainer> {trainers[0]},
                        Dogs = new Dog[] {dogs[0], dogs[1], dogs[2]},
                    },
                    new Practice()
                    {
                        Date = new DateTime(2014, 12, 1),
                        Trainers = new List<Trainer> {trainers[1]},
                        Dogs = new Dog[] {dogs[1], dogs[4], dogs[3]},
                    },

                    new Practice()
                    {
                        Date = new DateTime(2014, 12, 7),
                        Trainers = new List<Trainer> {trainers[1]},
                        Dogs = new Dog[] {dogs[0]},
                    }
                };

                var coursesInfo = new List<CourseInfo>()
                {
                    new CourseInfo()
                    {
                        Name = "General Obedience",
                        Description = @"General training is the foundation for building habits disciplining the animal and make it easy to manage behavior
                                        .Puppy accustomed to obedience and conductivity.The total rate is the same for all breeds of dogs,
                                        including two consecutive, overlapping stages: primary education and basic training."
                    },
                    new CourseInfo()
                    {
                        Name = "Agility Course",
                        Description = @"Agility course is fun for both the dog and for its owner. Agility is a relatively new sport in Bulgaria, which is actively involved as a dog and its driver.
                                      In agility course strictly adheres to the international rules of agility and anyone wishing to sporuva should be familiar with it in advance. Agility courses are divided into levels. In the first level of the dog and its driver are introduced to each obstacle and the rules that need to pass through it. At the end of the first level starts angling light paths of several obstacles in which the dog must pass led by their leader. In each upper level tracks are becoming more complex and include more variety of obstacles.
                                      Agility sport is intense fun for dogs and drivers, and the pleasure which our four-legged friends go through obstacles makes us not stop sporulated together. Worth to try!"
                    }
                };

                var courses = new List<Course>()
                {
                    new Course()
                    {
                        Status = CourseStatus.Ongoing,
                        Practices = new Practice[] {practices[0], practices[1]},
                        Info = coursesInfo[1]
                    },
                    new Course()
                    {
                        Status = CourseStatus.Ongoing,
                        Practices = new Practice[] { practices[2]},
                        Info = coursesInfo[0]
                    }
                };

                foreach (var course in courses)
                {
                    databaseContext.Courses.Add(course);
                }

                databaseContext.SaveChanges();
            }
        }
    }
}
