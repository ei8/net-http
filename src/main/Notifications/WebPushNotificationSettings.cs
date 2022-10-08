namespace ei8.Net.Http.Notifications
{
    public class WebPushNotificationSettings
    {
        public string PushOwner { get; set; }
        public string PushPublicKey { get; set; }
        public string PushPrivateKey { get; set; }

        public WebPushNotificationSettings(string pushOwner, string pushPublicKey, string pushPrivateKey)
        {
            PushOwner = pushOwner;
            PushPublicKey = pushPublicKey;
            PushPrivateKey = pushPrivateKey;
        }
    }
}
