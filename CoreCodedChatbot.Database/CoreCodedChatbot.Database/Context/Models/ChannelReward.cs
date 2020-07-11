using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class ChannelReward
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ChannelRewardId { get; set; }
        public string RewardTitle { get; set; }
        public string RewardDescription { get; set; }

        public virtual ICollection<ChannelRewardRedemption> Redemptions { get; set; }
    }
}