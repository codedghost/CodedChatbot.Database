using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class ChannelRewardMap : EntityTypeConfiguration<ChannelReward>
    {
        public override void Map(EntityTypeBuilder<ChannelReward> builder)
        {
            builder.ToTable("ChannelRewards");

            builder.HasKey(t => t.ChannelRewardId);

            builder.Property(t => t.ChannelRewardId).HasColumnName("ChannelRewardId").IsRequired();
            builder.Property(t => t.RewardTitle).HasColumnName("RewardTitle").IsRequired();
            builder.Property(t => t.RewardDescription).HasColumnName("RewardDescription").IsRequired();

            builder.HasMany(channelReward => channelReward.Redemptions)
                .WithOne(channelRewardRedemption => channelRewardRedemption.Reward)
                .HasForeignKey(channelRewardRedemption => channelRewardRedemption.ChannelRewardId);
        }
    }
}