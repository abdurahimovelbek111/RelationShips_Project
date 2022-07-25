using Microsoft.EntityFrameworkCore;
using RelationShips_Project.Models;

namespace RelationShips_Project.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=RelationShips_Project;" +
                "Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(path);
        }
        
        #region One To One , One To Many in DbSet<class>
        //public virtual DbSet<People> Peoples { get; set; }
        // public virtual DbSet<Address> Addresses { get; set; }
        // public virtual DbSet<Car> Cars { get; set; }
        #endregion
    }
}
