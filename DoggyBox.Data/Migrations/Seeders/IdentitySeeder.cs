namespace DoggyBox.Data.Migrations.Seeders
{
    using System;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using DoggyBox.Common;
    using DoggyBox.Model;

    public class IdentitySeeder
    {
        public static void Seed(ApplicationDbContext databaseContext)
        {
            if (!databaseContext.Roles.Any(r => r.Name == GlobalConstants.AdminRole))
            {
                var store = new RoleStore<IdentityRole>(databaseContext);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = GlobalConstants.AdminRole };

                manager.Create(role);
            }

            if (!databaseContext.Roles.Any(r => r.Name == GlobalConstants.UserRole))
            {
                var store = new RoleStore<IdentityRole>(databaseContext);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = GlobalConstants.UserRole };

                manager.Create(role);
            }

            if (!databaseContext.Users.Any(u => u.UserName == "admin@admin.bg"))
            {
                var store = new UserStore<ApplicationUser>(databaseContext);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser
                {
                    UserName = "admin@admin.bg",
                    Email = "admin@admin.bg",
                    CreatedOn = DateTime.Now
                };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, GlobalConstants.AdminRole);
            }

            if (!databaseContext.Users.Any(u => u.UserName == "user@user.bg"))
            {
                var dog = new Dog() {Name= "Lucky", Breed = "Beagle", DateOfBirth = new DateTime(2014, 1, 2)};

                var store = new UserStore<ApplicationUser>(databaseContext);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser
                {
                    UserName = "user@user.bg",
                    Email = "user@user.bg",
                    CreatedOn = DateTime.Now,
                    Dogs = new Dog[] {dog}
                };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, GlobalConstants.UserRole);
            }

            databaseContext.SaveChanges();
        }
    }
}
