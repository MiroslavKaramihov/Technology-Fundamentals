using BandRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BandRegister.Data
{
    public class BandDbContext : DbContext
    {
        public DbSet<Band> Band { get; set; }

        private const string ConnectionString = @"Server=ACER-NB\SQLEXPRESS01;Database=BandkDb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
