using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class ChannelRewardRedemption
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ChannelRewardRedemptionId { get; set; }
        public Guid ChannelRewardId { get; set; }
        public string RedeemedBy { get; set; }
        public DateTime RedeemedAt { get; set; }
        public bool Processed { get; set; }

        public virtual ChannelReward Reward { get; set; }
    }
}