﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class SongRequest : IEntityWithUsername
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongRequestId { get; set; }
        public string Username { get; set; }
        public int? SongId { get; set; }
        public DateTime RequestTime { get; set; }
        
        public bool Played { get; set; }
        public bool InDrive { get; set; }
        public DateTime? VipRequestTime { get; set; }
        public DateTime? SuperVipRequestTime { get; set; }
        public string RequestText { get; set; } 

        public virtual Song Song { get; set; }
    }
}
