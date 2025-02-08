using LevelUP.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarRentalManagement.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<LevelUPUser>
    {
        public void Configure(EntityTypeBuilder<LevelUPUser> builder)
        {
            var hasher = new PasswordHasher<LevelUPUser>();
            builder.HasData(
            new LevelUPUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                Name= "adminUser",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new LevelUPUser
            {
                Id = "f2c5e7a3-50fa-46d5-9bc7-1c3f09f8c6b2",
                Email = "cust@localhost.com",
                NormalizedEmail = "CUST@LOCALHOST.COM",
                Name = "custUser",
                UserName = "cust@localhost.com",
                NormalizedUserName = "CUST@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}