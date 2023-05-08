using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class Quote : IEntityWithUsername
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuoteId { get; set; }
        public string QuoteText { get; set; }
        public DateTime LastEdited { get; set; }
        public string Username { get; set; }
        public bool Enabled { get; set; }
        public string LastEditedBy { get; set; }
    }
}