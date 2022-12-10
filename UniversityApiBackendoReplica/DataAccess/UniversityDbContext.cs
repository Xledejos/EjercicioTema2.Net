using Microsoft.EntityFrameworkCore;
using UniversityApiBackendoReplica.Models.DataModels;

namespace UniversityApiBackendoReplica.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        // TODO: Add DbSet (tables of the data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Temary>? Temarys { get; set;}
    }
}
