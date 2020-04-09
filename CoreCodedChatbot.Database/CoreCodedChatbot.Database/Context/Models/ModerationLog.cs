using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Enums;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class ModerationLog
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