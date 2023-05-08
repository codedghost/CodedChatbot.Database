using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class InfoCommand : IEntityWithUsername
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InfoCommandId { get; set; }
        public string InfoText { get; set; }
        public string InfoHelpText { get; set; }
        public string Username { get; set; }

        public virtual ICollection<InfoCommandKeyword> InfoCommandKeywords { get; set; }
    }
}
