using Microsoft.EntityFrameworkCore;

namespace WebAppCodeFirst.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options): base(options)
        {
            
        }

        public DbSet<Product> tblProduct { get; set; }

        public DbSet<Colour> tblColour { get; set; }

        //Data Seeding=>inserting sample data in newly created table

        //type override onmodelcreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colour>().HasData
                (
                    new Colour { Cid=1,Cname="Red"},
                    new Colour { Cid=2,Cname="Blue"}
                );
        }
    }
}
