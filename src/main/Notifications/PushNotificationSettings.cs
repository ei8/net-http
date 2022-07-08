namespace ei8.Net.Http.Notifications
{
    public class PushNotificationSettings
    {
        public string PushOwner { get; set; }
        public string PushPublicKey { get; set; }
        public string PushPrivateKey { get; set; }

        public PushNotificationSettings(string pushOwner, string pushPublicKey, string pushPrivateKey)
        {
            PushOwner = pushOwner;
            PushPublicKey = pushPublicKey;
            PushPrivateKey = pushPrivateKey;
        }
    }
}
