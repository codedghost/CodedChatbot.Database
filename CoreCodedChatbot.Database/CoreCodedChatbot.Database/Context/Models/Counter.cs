using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class Counter : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CounterName { get; set; }
        public string CounterSuffix { get; set; }
        public int CounterValue { get; set; }
        public bool Archived { get; set; }
    }
}