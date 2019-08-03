using Microsoft.EntityFrameworkCore;
using Rednetnorf.Models;

namespace Rednetnorf.DAL
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=rednetnorf;user=root;password=123");
        }
    }
}