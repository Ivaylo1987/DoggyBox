namespace DoggyBox.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DoggyBox.Data;
    using DoggyBox.Data.Migrations.Seeders;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(DoggyBox.Data.ApplicationDbContext context)
        {
            IdentitySeeder.Seed(context);
            CoursesSeeder.Seed(context);
        }
    }
}
