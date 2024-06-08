using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping;

public class YlylSessionMap : EntityTypeConfiguration<YlylSession>
{
    public override void Map(EntityTypeBuilder<YlylSession> builder)
    {
        builder.ToTable("YlylSessions");

        builder.HasKey(y => y.SessionId);

        builder.Property(y => y.SessionId).HasColumnName("SessionId").IsRequired();
        builder.Property(y => y.IsActive).HasColumnName("IsActive").IsRequired();
        builder.Property(y => y.OpenedAt).HasColumnName("OpenedAt").IsRequired();
        builder.Property(y => y.ClosedAt).HasColumnName("ClosedAt");


    }
}