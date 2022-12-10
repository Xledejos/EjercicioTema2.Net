using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) 
        { 

        }
       
        // TODO: Add DbSet (tables of the data base)
        public DbSet<User>? Users { get; set; }
    }
}
