using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class SearchSynonymRequest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SearchSynonymRequestId { get; set; }
        public string SynonymRequest { get; set; }
        public string Username { get; set; }
    }
}