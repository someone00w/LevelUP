using LevelUP.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LevelUP.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<LevelUPUser>
    {
        public void Configure(EntityTypeBuilder<LevelUPUser> builder)
        {
            var hasher = new PasswordHasher<LevelUPUser>();

            builder.HasData(
                new LevelUPUser
                {
                    Id = "314", // Unique ID for Admin user
                    Email = "admin@fitnessapp.com",
                    NormalizedEmail = "ADMIN@FITNESSAPP.COM",
                    UserName = "admin@fitnessapp.com",
                    FirstName="Admin",
                    LastName="User",
                    NormalizedUserName = "ADMIN@FITNESSAPP.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}