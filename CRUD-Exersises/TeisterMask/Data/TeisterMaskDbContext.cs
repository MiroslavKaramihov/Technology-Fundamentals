using Microsoft.EntityFrameworkCore;
using TeisterMask.Models;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        private const string ConnectionString = @"Server=ACER-NB\SQLEXPRESS01;Database=TeisterMasckDb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
