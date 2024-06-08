﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class YlylReward
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RewardId { get; set; }
        public bool IsRedeemed { get; set; } = false;
        public string RewardValue { get; set; }
        public int? YlylEntryId { get; set; }

        public virtual YlylEntry Entry { get; set; }
    }
}
