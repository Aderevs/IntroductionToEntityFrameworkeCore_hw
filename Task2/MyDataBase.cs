using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class MyDataBase : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MyDataBase()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EntityIntroductionDb;Trusted_Connection=True;TrustServerCertificate=True;")
                .LogTo(DebugHelper.WriteLine, LogLevel.Information);
        }
    }
    public static class DebugHelper
    {
        public static void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
