using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CoreCodedChatbot.Database.Context.Interfaces;

namespace CoreCodedChatbot.Database.Context.Models;

public class YlylEntry : IEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EntryId { get; set; }
    public int YlylSubmissionId { get; set; }
    public bool HasWon { get; set; }
    public bool IsImage { get; set; }
    public bool HasReceivedReward { get; set; }
    public int? YlylRewardId { get; set; }

    public virtual YlylSubmission YlylSubmission { get; set; }
    public virtual YlylReward Reward { get; set; }
}