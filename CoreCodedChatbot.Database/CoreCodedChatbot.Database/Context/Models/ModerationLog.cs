using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Enums;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class ModerationLog : IEntityWithUsername
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModerationLogId { get; set; }
        public string Username { get; set; }
        public ModerationAction Action { get; set; }
        public DateTime ActionTakenTime { get; set; }
        public string ExtraInformation { get; set; }
    }
}