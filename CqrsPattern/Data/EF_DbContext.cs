using CqrsPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace CqrsPattern.Data
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Book> Books { get;set;}
    }
}