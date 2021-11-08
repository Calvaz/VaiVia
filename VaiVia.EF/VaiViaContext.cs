using Microsoft.EntityFrameworkCore;
using ViaVai.Core.Entities;

namespace VaiVia.EF
{
    public class VaiViaContext : DbContext
    {
        DbSet<Nations> Nations { get; set; }
        DbSet<Users> Users { get; set; }

        public VaiViaContext(DbContextOptions<VaiViaContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Nations>(new NationsConfiguration());
            modelBuilder.ApplyConfiguration<Users>(new UsersConfiguration());
        }

    }
}
