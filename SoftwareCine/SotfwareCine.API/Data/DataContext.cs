using Microsoft.EntityFrameworkCore;
using SotfwareCine.Shared.Entities;

namespace SotfwareCine.API.Data

{

    public class DataContext:DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Teatro> Teatros { get; set; }
        public DbSet<Horario> Horarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Horario>()
                .HasOne(t => t.Teatro)
                .WithMany(h => h.Horarios)
                .HasForeignKey(t => t.IdTeatro);
        }
    }

}
