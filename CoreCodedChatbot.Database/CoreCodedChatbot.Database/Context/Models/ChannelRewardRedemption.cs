using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class ChannelRewardRedemption : IEntityWithUsername
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ChannelRewardRedemptionId { get; set; }
        public Guid ChannelRewardId { get; set; }
        public DateTime RedeemedAt { get; set; }
        public string Username { get; set; }
        public bool Processed { get; set; }

        public virtual ChannelReward Reward { get; set; }
    }
}