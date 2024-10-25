using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyModel.Models;

namespace StudyModel.Data.Configuration
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder
            .Property(b => b.Url)
            .IsRequired();

            builder
            .HasKey(x => x.BlogId)
            .HasName("PrimaryKey_BlogId");
        }
    }
}
