using StudyModel.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyModel.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        [NotMapped]
        public string Content { get; set; }
        public Status UserStatus { get; set; }
        public Blog Blog { get; set; }
    }
}
