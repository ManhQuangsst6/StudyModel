using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using StudyModel.Enum;
using StudyModel.Models;
using System.Reflection;

namespace StudyModel.NewFolder
{
    public class DataContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<BlogMetadata> BlogMetadatas { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //cach 1
            // modelBuilder.Entity<Blog>().Property(b => b.Url).IsRequired();

            // cach 2
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogEntityTypeConfiguration).Assembly);
            //modelBuilder.ApplyConfiguration(new BlogEntityTypeConfiguration());

            modelBuilder.Entity<Blog>().Property(b => b.Url).IsRequired();

            modelBuilder.Entity<Post>()
           .Property(u => u.UserStatus)
           .HasConversion(
               v => v.ToString(),  // Chuyển đổi từ Enum sang String

               v => (Status)Status.Parse(typeof(Status), v));
            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Remove(typeof(ForeignKeyIndexConvention));
        }
    }
}
