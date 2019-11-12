using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class LogEntryMap : EntityTypeConfiguration<LogEntry>
    {
        public override void Map(EntityTypeBuilder<LogEntry> builder)
        {
            builder.ToTable("LogEntry");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.Level).HasColumnName("Level").IsRequired();
            builder.Property(t => t.LoggedAt).HasColumnName("LoggedAt").IsRequired();
            builder.Property(t => t.Message).HasColumnName("Message").IsRequired();
            builder.Property(t => t.Logger).HasColumnName("Logger");
            builder.Property(t => t.Callsite).HasColumnName("Callsite");
            builder.Property(t => t.Exception).HasColumnName("Exception");
            builder.Property(t => t.StackTrace).HasColumnName("StackTrace");
        }
    }
}