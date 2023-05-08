using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Enums;
using CoreCodedChatbot.Database.Context.Interfaces;
using Microsoft.VisualBasic;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class ChannelReward : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ChannelRewardId { get; set; }
        public string RewardTitle { get; set; }
        public string RewardDescription { get; set; }
        
        [EnumDataType(typeof(CommandTypes))]
        public CommandTypes CommandType { get; set; }

        public virtual ICollection<ChannelRewardRedemption> Redemptions { get; set; }
    }
}