using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class Song
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }
        public int CFId { get; set; }
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string AlbumName { get; set; }
        public string Tuning { get; set; }
        public DateTime UploadedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public int TotalDownloads { get; set; }
        public string ChartedPaths { get; set; }
        public bool IsOfficial { get; set; }
        public int CharterId { get; set; }
        public virtual List<SongUrlVersion> Urls { get; set; }

        public virtual List<SongRequest> SongRequests { get; set; }
        public virtual Charter Charter { get; set; }
    }
}
