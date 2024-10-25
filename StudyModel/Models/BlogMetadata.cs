using System.ComponentModel.DataAnnotations.Schema;

namespace StudyModel.Models
{
    [NotMapped]
    public class BlogMetadata
    {
        public DateTime LoadedFromDatabase { get; set; }
    }
}
