using ei8.Net.Http.Notifications;
using ei8.Net.Http.PayloadHashing;
using ei8.Net.Notifications;
using ei8.Net.PayloadHashing;
using Microsoft.Extensions.DependencyInjection;

namespace ei8.Net.Http
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHttpServices(this IServiceCollection services)
        {
            services.AddScoped<INotificationService<WebPushNotificationPayload, WebPushReceiver>, WebPushNotificationService>();
            services.AddScoped<IPayloadHashService, HttpPayloadHashService>();
            return services;
        }
    }
}
