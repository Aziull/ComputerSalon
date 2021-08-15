using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataLayer
{
    public class MainDbContext : DbContext
    {
        public DbSet<Detail> Details { get; set; }
        public DbSet<Value> Values  { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Type> Types  { get; set; }
        public DbSet<SystemUnit> SystemUnits  { get; set; }
        public DbSet<SystemUnitDetail> SystemUnitDetails  { get; set; }
        

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }
    }
}
