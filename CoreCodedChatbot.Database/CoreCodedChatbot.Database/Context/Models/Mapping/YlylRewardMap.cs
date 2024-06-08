using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping;

public class YlylRewardMap : EntityTypeConfiguration<YlylReward>
{
    public override void Map(EntityTypeBuilder<YlylReward> builder)
    {
        builder.ToTable("YlylRewards");

        builder.HasKey(y => y.RewardId);

        builder.Property(y => y.RewardId).HasColumnName("RewardId").IsRequired();
        builder.Property(y => y.IsRedeemed).HasColumnName("IsRedeemed").HasDefaultValue(false).IsRequired();
        builder.Property(y => y.RewardValue).HasColumnName("RewardValue").IsRequired();
        builder.Property(y => y.YlylSubmissionId).HasColumnName("YlylSubmissionId");

        builder.HasOne(y => y.Submission)
            .WithOne(y => y.Reward)
            .HasForeignKey<YlylReward>(yr => yr.YlylSubmissionId);
    }
}