﻿using Microsoft.AspNetCore.Identity;

namespace LevelUP.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class LevelUPUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
