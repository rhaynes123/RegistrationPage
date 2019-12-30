﻿using System;
using Microsoft.EntityFrameworkCore;

namespace RegistrationPage.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
