#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginWebApp.Models;

namespace LoginWebApp.Data
{
    public class LoginWebAppContext : DbContext
    {
        public LoginWebAppContext (DbContextOptions<LoginWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<LoginWebApp.Models.User> User { get; set; }
    }
}
