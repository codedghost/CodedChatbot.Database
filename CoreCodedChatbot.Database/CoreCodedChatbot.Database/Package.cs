using CoreCodedChatbot.Database.Context;
using CoreCodedChatbot.Database.Context.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CoreCodedChatbot.Database
{
    public static class Package
    {
        public static ServiceCollection AddDbContextFactory(this ServiceCollection services)
        {
            services.AddTransient<IChatbotContextFactory, ChatbotContextFactory>();

            return services;
        }
    }
}