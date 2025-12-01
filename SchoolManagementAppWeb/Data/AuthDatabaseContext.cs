using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementAppWeb.Data
{
    public class AuthDatabaseContext:IdentityDbContext
    {
        public AuthDatabaseContext(DbContextOptions<AuthDatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed Roles (Student, Educator, Admin)
            var studentRoleId = "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3";
            var educatorRoleId = "227927f4-33e4-4baa-9edb-a6631bca1227";
            var adminRoleId = "77c42450-7226-439b-92cd-bfc826d26cb6";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Student",
                    NormalizedName = "Student",
                    Id = studentRoleId,
                    ConcurrencyStamp = studentRoleId
                },
                new IdentityRole
                {
                    Name= "Educator",
                    NormalizedName = "Educator",
                    Id = educatorRoleId,
                    ConcurrencyStamp = educatorRoleId
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                }
            
            };
            builder.Entity<IdentityRole>().HasData(roles);

            // Seed SuperAdminUser
            var superAdminId = "d6a53300-8a84-4e49-b23a-ae7dd540d59c";
            var superAdminUser = new IdentityUser
            {
                UserName = "director@ABCSchool.com",
                Email = "director@ABCSchool.com",
                NormalizedEmail = "director@ABCSchool.com".ToUpper(),
                NormalizedUserName = "director@ABCSchool.com".ToUpper(),
                Id = superAdminId
            };
            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(superAdminUser, "director@123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);

            // Add All roles to SuperAdminUser
            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = educatorRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = superAdminId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);

            // Seed EducatorUser
            var educatorUserId = "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc";
            var educatorUser = new IdentityUser
            {
                UserName = "educator@ABCSchool.com",
                Email = "educator@ABCSchool.com",
                NormalizedEmail = "educator@ABCSchool.com".ToUpper(),
                NormalizedUserName = "educator@ABCSchool.com".ToUpper(),
                Id = educatorUserId
            };
            educatorUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(educatorUser, "educator@123");

            builder.Entity<IdentityUser>().HasData(educatorUser);

            // Add roles to EducatorUser
            var educatorRoles = new List<IdentityUserRole<string>>
            {
           
                new IdentityUserRole<string>
                {
                    RoleId = educatorRoleId,
                    UserId = educatorUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = educatorUserId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(educatorRoles);

            // Seed StudentUser
            var studentUserId = "eb2b606e-e91e-424a-8e4a-1590c018b3b9";
            var studentUser = new IdentityUser
            {
                UserName = "student@ABCSchool.com",
                Email = "student@ABCSchool.com",
                NormalizedEmail = "student@ABCSchool.com".ToUpper(),
                NormalizedUserName = "student@ABCSchool.com".ToUpper(),
                Id = studentUserId
            };
            studentUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(studentUser, "student@123");

            builder.Entity<IdentityUser>().HasData(studentUser);

            // Add roles to EducatorUser
            var studentRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = studentRoleId,
                    UserId = studentUserId
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(studentRoles);
        }
    }
}
