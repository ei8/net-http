using ei8.Net.Notifications;

namespace ei8.Net.Http.Notifications
{
    public class WebPushReceiver : INotificationReceiver
    {
        public string Endpoint { get; set; }
        public string P256DH { get; set; }
        public string Auth { get; set; }
    }
}
