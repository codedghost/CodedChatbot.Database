using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class SongMap : EntityTypeConfiguration<Song>
    {
        public override void Map(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Songs");

            builder.HasKey(t => t.SongId);

            builder.Property(t => t.SongId).HasColumnName("SongId").IsRequired();
            builder.Property(t => t.CFId).HasColumnName("CFId").IsRequired();
            builder.Property(t => t.SongName).HasColumnName("SongName").IsRequired();
            builder.Property(t => t.SongArtist).HasColumnName("SongArtist").IsRequired();
            builder.Property(t => t.AlbumName).HasColumnName("AlbumName").IsRequired();
            builder.Property(t => t.Tuning).HasColumnName("Tuning").IsRequired();
            builder.Property(t => t.Version).HasColumnName("Version").IsRequired();
            builder.Property(t => t.UploaderUsername).HasColumnName("UploaderUsername").IsRequired();
            builder.Property(t => t.UploadedDateTime).HasColumnName("UploadedDateTime").IsRequired();
            builder.Property(t => t.UpdatedDateTime).HasColumnName("UpdatedDateTime").IsRequired();
            builder.Property(t => t.TotalDownloads).HasColumnName("TotalDownloads").IsRequired();
            builder.Property(t => t.ChartedPaths).HasColumnName("ChartedPaths").IsRequired();
            builder.Property(t => t.DownloadUrl).HasColumnName("DownloadUrl").IsRequired();
            builder.Property(t => t.IsOfficial).HasColumnName("IsOfficial").IsRequired();

            //builder.HasMany(t => t.SongRequests).WithOne(o => o.Song).HasForeignKey(k => k.SongId);
        }
    }
}
