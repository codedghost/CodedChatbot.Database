using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class SongUrlVersionMapping : EntityTypeConfiguration<SongUrlVersion>
    {
        public override void Map(EntityTypeBuilder<SongUrlVersion> builder)
        {
            builder.ToTable("SongUrlVersions");

            builder.HasKey(t => t.SongUrlVersionId);

            builder.Property(t => t.SongUrlVersionId).HasColumnName("SongUrlVersionId").IsRequired();
            builder.Property(t => t.SongId).HasColumnName("SongId").IsRequired();
            builder.Property(t => t.Version).HasColumnName("Version").IsRequired();
            builder.Property(t => t.Url).HasColumnName("Url").IsRequired();

            builder.HasOne(t => t.Song).WithMany(t => t.Urls).HasForeignKey(k => k.SongId);
        }
    }
}