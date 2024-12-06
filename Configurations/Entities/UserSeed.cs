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
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4", // Unique ID for Admin user
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    FirstName = "Admin",
                    LastName = "User",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}