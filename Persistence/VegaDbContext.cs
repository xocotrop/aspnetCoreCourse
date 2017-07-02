
using Microsoft.EntityFrameworkCore;
using vegas.Models;

namespace vegas.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Make> Makes {get;set;}
        // public DbSet<Model> Model {get;set;}
    }
}