using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        private const string ConnectionString = @"Server=ACER-NB\SQLEXPRESS01;Database=ToDoListDb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
