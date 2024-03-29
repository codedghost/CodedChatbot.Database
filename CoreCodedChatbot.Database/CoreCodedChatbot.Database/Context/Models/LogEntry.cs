﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class LogEntry : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Level { get; set; }
        public DateTime LoggedAt { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; }
        public string ProcessName { get; set; }
        public string AppDomain { get; set; }
    }
}