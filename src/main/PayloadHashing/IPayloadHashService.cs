using System.Threading.Tasks;

namespace ei8.Net.Http.PayloadHashing
{
    public interface IPayloadHashService
    {
        Task<string> GetPayloadHashAsync(string url);
    }
}
