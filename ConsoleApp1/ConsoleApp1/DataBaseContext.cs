using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class DataBaseContext : DbContext
    {
        public readonly string Path = @"C:\Users\bhanu\Desktop\MINE\EE3206 - GUI Programming\Lecture_12_CLI_DataBase\student_db01.bd";
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlite($"Data Source = {Path}"); 
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
