using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping;

public class YlylEntryMap : EntityTypeConfiguration<YlylEntry>
{
    public override void Map(EntityTypeBuilder<YlylEntry> builder)
    {
        builder.ToTable("YlylEntries");

        builder.HasKey(y => y.EntryId);

        builder.Property(y => y.EntryId).HasColumnName("EntryId").IsRequired();
        builder.Property(y => y.YlylSubmissionId).HasColumnName("YlylSubmissionId").IsRequired();
        builder.Property(y => y.HasWon).HasColumnName("HasWon").HasDefaultValue(false).IsRequired();
        builder.Property(y => y.IsImage).HasColumnName("IsImage").IsRequired();
        builder.Property(y => y.HasReceivedReward).HasColumnName("HasReceivedReward").HasDefaultValue(false)
            .IsRequired();
        builder.Property(y => y.YlylRewardId).HasColumnName("YlylRewardId");

        builder.HasOne(y => y.YlylSubmission)
            .WithMany(y => y.YlylEntries)
            .HasForeignKey(y => y.YlylSubmissionId);

        builder.HasOne(y => y.Reward)
            .WithOne(y => y.Entry)
            .HasForeignKey<YlylEntry>(ys => ys.YlylRewardId);
    }
}