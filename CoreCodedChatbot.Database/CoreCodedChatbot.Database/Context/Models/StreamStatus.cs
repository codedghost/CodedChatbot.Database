using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class StreamStatus : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StreamStatusId { get; set; }
        public string BroadcasterUsername { get; set; }
        public bool IsOnline { get; set; }
    }
}
