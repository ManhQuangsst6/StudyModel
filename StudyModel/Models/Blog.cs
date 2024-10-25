using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyModel.Models
{
    [Table("Blogs")]
    [Index(nameof(Url))]
    public class Blog
    {
        public int BlogId { get; set; }
        public required string Url { get; set; }
        public List<Post> Posts { get; set; }

        [Column("Blog_Title")]
        private string _title; // Backing field

        public string Title
        {
            get => _title;
            set => _title = value;
        }
    }
}
