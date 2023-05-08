using Microsoft.EntityFrameworkCore;

namespace CoreCodedChatbot.Database.Context.Interfaces
{
    public interface IChatbotContextFactory
    {
        IChatbotContext Create();
    }
}