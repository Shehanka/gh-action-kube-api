using CashflowAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
            
            optionsBuilder.UseSqlServer("Server=tcp:cashflow-server.database.windows.net,1433;Initial Catalog=cashflow;Persist Security Info=False;User ID=chamod;Password=jYxped-0qente-jezdis;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}