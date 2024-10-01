using Microsoft.EntityFrameworkCore;
using StudyModel.Data.Configuration;
using StudyModel.Models;

namespace StudyModel.NewFolder
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //cach 1
            // modelBuilder.Entity<Blog>().Property(b => b.Url).IsRequired();

            // cach 2
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
