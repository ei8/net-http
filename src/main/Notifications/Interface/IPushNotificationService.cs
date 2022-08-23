using System.Threading.Tasks;

namespace ei8.Net.Http.Notifications.Interface
{
    public interface IPushNotificationService<in T, in U> 
        where T: INotificationPayload 
        where U : INotificationReceiver
    {
        Task SendAsync(T payload, U subscription);
    }
}
