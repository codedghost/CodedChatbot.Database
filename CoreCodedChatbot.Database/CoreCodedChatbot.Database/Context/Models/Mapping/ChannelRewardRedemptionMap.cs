using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class ChannelRewardRedemptionMap : EntityTypeConfiguration<ChannelRewardRedemption>
    {
        public override void Map(EntityTypeBuilder<ChannelRewardRedemption> builder)
        {
            builder.ToTable("ChannelRewardRedemption");

            builder.HasKey(t => t.ChannelRewardRedemptionId);

            builder.Property(t => t.ChannelRewardRedemptionId).HasColumnName("ChannelRewardRedemptionId").IsRequired();
            builder.Property(t => t.ChannelRewardId).HasColumnName("ChannelRewardId").IsRequired();
            builder.Property(t => t.RedeemedBy).HasColumnName("RedeemedBy").IsRequired();
            builder.Property(t => t.RedeemedAt).HasColumnName("RedeemedAt").IsRequired();
            builder.Property(t => t.Processed).HasColumnName("Processed").IsRequired();

            builder.HasOne(channelRewardRedemption => channelRewardRedemption.Reward)
                .WithMany(channelReward => channelReward.Redemptions)
                .HasForeignKey(channelRewardRedemption => channelRewardRedemption.ChannelRewardId);
        }
    }
}