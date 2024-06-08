using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreCodedChatbot.Database.Context.Models;

public class YlylSubmission
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SubmissionId { get; set; }
    public int SessionId { get; set; }
    public ulong ChannelId { get; set; }
    public ulong MessageId { get; set; }
    public DateTime SubmissionTime { get; set; }

    public virtual List<YlylEntry> YlylEntries { get; set; }
    public virtual YlylSession Session { get; set; }
}