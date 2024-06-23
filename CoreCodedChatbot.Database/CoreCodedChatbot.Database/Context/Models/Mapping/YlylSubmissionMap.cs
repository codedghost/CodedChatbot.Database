using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping;

public class YlylSubmissionMap : EntityTypeConfiguration<YlylSubmission>
{
    public override void Map(EntityTypeBuilder<YlylSubmission> builder)
    {
        builder.ToTable("YlylSubmissions");

        builder.HasKey(y => y.SubmissionId);

        builder.Property(y => y.SubmissionId).HasColumnName("SubmissionId").IsRequired();
        builder.Property(y => y.SessionId).HasColumnName("SessionId").IsRequired();
        builder.Property(y => y.ChannelId).HasColumnName("ChannelId").IsRequired();
        builder.Property(y => y.MessageId).HasColumnName("MessageId").IsRequired();
        builder.Property(y => y.UserId).HasColumnName("UserId").IsRequired().HasDefaultValue(1);
        builder.Property(y => y.SubmissionTime).HasColumnName("SubmissionTime").IsRequired();
        builder.Property(y => y.TotalImages).HasColumnName("TotalImages").HasDefaultValue(0);
        builder.Property(y => y.TotalVideos).HasColumnName("TotalVideos").HasDefaultValue(0);

        builder.HasOne(y => y.Session)
            .WithMany(y => y.YlylSubmissions)
            .HasForeignKey(ys => ys.SessionId);
    }
}