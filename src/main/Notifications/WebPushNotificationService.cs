using ei8.Net.Notifications;
using System.Text.Json;
using System.Threading.Tasks;
using WebPush;

namespace ei8.Net.Http.Notifications
{
    public class WebPushNotificationService : INotificationService<WebPushNotificationPayload, WebPushReceiver>
    {
        private readonly VapidDetails vapidDetails;

        public WebPushNotificationService(WebPushNotificationSettings settings)
        {
            this.vapidDetails = new VapidDetails(settings.PushOwner, settings.PushPublicKey, settings.PushPrivateKey);
        }

        public async Task SendAsync(WebPushNotificationPayload payload, WebPushReceiver subscription)
        {
            var pushSubscription = new PushSubscription(subscription.Endpoint, subscription.P256DH, subscription.Auth);
            var jsonPayload = JsonSerializer.Serialize(payload, Constants.CamelCaseSerialization);

            using (var client = new WebPushClient())
            {
                await client.SendNotificationAsync(pushSubscription, jsonPayload, this.vapidDetails);
            }
        }
    }
}
