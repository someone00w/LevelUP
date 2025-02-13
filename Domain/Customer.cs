﻿using LevelUP.Data;

namespace LevelUP.Domain
{
    // Customer Class
    public class Customer : BaseDomainModel
    {
        public int CustomerId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public int XPAmount { get; set; } = 0;
        public string Rank { get; set; } = "D";

        //Foreign key to LevelUPUser
        public string? UserId { get; set; }
        //navigation
        public LevelUPUser? User { get; set; }
    }
}