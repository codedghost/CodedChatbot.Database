using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class SearchSynonymRequest : IEntityWithUsername
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SearchSynonymRequestId { get; set; }
        public string SynonymRequest { get; set; }
        public string Username { get; set; }
    }
}