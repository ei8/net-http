using ei8.Net.Http.Notifications;
using ei8.Net.Http.Notifications.Interface;
using ei8.Net.Http.PayloadHashing;
using Microsoft.Extensions.DependencyInjection;

namespace ei8.Net.Http
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEi8Http(this IServiceCollection services)
        {
            services.AddScoped<IPushNotificationService<WebPushNotificationPayload, WebPushReceiver>, WebPushNotificationService>();
            services.AddScoped<IPayloadHashService, HttpPayloadHashService>();
            return services;
        }
    }
}
