using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class SongGuessingRecord : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongGuessingRecordId { get; set; }
        public string SongDetails { get; set; }
        public decimal FinalPercentage { get; set; }
        public bool UsersCanGuess { get; set; }
        public bool IsInProgress { get; set; }

        public virtual ICollection<SongPercentageGuess> SongPercentageGuesses { get; set; }
    }
}
