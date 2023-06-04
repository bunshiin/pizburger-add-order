using Microsoft.EntityFrameworkCore;
using pizburger.Entities.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace pizburger.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<order> orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new OrderConfiguration());

            base.OnModelCreating(modelbuilder);

        }



    }
}
