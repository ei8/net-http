using System.Threading.Tasks;

namespace ei8.Net.Http.Notifications
{
    public interface IPushNotificationService
    {
        Task SendAsync(PushNotificationPayload payload, WebPushReceiver subscription);
    }
}
