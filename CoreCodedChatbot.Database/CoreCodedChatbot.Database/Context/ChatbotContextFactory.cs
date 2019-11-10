using CoreCodedChatbot.Database.Context.Interfaces;
using CoreCodedChatbot.Secrets;

namespace CoreCodedChatbot.Database.Context
{
    public class ChatbotContextFactory : IChatbotContextFactory
    {
        private readonly ISecretService _secretService;

        public ChatbotContextFactory(ISecretService secretService)
        {
            _secretService = secretService;
        }

        public IChatbotContext Create()
        {
            return new ChatbotContext(_secretService);
        }
    }
}
