using Microsoft.EntityFrameworkCore;
using UniversityApiBackendoReplica.Models.DataModels;

namespace UniversityApiBackendoReplica.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        // TODO: Add DbSet (tables of the data base)
        public DbSet<User>? Users { get; set; }
    }
}
