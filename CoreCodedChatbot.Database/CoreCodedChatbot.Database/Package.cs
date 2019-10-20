using CoreCodedChatbot.Database.Context;
using CoreCodedChatbot.Database.Context.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CoreCodedChatbot.Database
{
    public static class Package
    {
        public static IServiceCollection AddDbContextFactory(this IServiceCollection services)
        {
            services.AddTransient<IChatbotContextFactory, ChatbotContextFactory>();

            return services;
        }
    }
}