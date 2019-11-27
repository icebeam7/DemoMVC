using Microsoft.EntityFrameworkCore;

using DemoMVC.Models;

namespace DemoMVC.Context
{
    public class SchoolDatabaseContext : DbContext
    {
        public SchoolDatabaseContext(DbContextOptions<SchoolDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
