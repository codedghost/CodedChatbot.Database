using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class SongUrlVersion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongUrlVersionId { get; set; }
        public int SongId { get; set; }
        public decimal Version { get; set; }
        public string Url { get; set; }

        public virtual Song Song { get; set; }
    }
}