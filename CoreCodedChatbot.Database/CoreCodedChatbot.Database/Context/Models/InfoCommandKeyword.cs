using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class InfoCommandKeyword : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string InfoCommandKeywordText { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InfoCommandId { get; set; }

        public virtual InfoCommand InfoCommand {get; set; }
    }
}
