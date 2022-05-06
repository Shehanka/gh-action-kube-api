using CashflowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CashflowAPI.DB
{
    public class DbConnection : DbContext
    {
        public DbConnection()
        {
        }

        public DbConnection(DbContextOptions<DbConnection> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=tcp:cashflow-server.database.windows.net,1433;Initial Catalog=cashflow;Persist Security Info=False;User ID=chamod;Password=jYxped-0qente-jezdis;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.Property(u => u.Username).HasMaxLength(100);
                entity.Property(u => u.Password).HasMaxLength(100);
                entity.Property(u => u.Email).HasMaxLength(100);
                entity.Property(u => u.FirstName).HasMaxLength(100);
                entity.Property(u => u.LastName).HasMaxLength(100);
            });
        }
    }
}