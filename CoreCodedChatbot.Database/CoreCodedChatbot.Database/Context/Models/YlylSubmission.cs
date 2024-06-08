using System;
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
    public bool HasWon { get; set; }
    public bool IsImage { get; set; }
    public bool HasReceivedReward { get; set; }
    public DateTime SubmissionTime { get; set; }
    public int? YlylRewardId { get; set; }

    public virtual YlylSession Session { get; set; }
    public virtual YlylReward Reward { get; set; }
}