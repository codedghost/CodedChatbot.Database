using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class ModerationLogMap : EntityTypeConfiguration<ModerationLog>
    {
        public override void Map(EntityTypeBuilder<ModerationLog> builder)
        {
            builder.ToTable("ModerationLogs");

            builder.HasKey(t => t.ModerationLogId);

            builder.Property(t => t.ModerationLogId).HasColumnName("ModerationLogId").IsRequired();
            builder.Property(t => t.Username).HasColumnName("Username").IsRequired();
            builder.Property(t => t.Action).HasColumnName("Action").IsRequired();
            builder.Property(t => t.ActionTakenTime).HasColumnName("ActionTakenTime").IsRequired();
            builder.Property(t => t.ExtraInformation).HasColumnName("ExtraInformation");
        }
    }
}