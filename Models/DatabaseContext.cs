using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceDetection.Models
{
    public class DatabaseContext : DbContext
    {

        private readonly string _connectionString;
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

       
        public DbSet<UserProfile> UserProfile { get; set; }
    }
}
