using System.Net.Http;
using System.Threading.Tasks;

namespace FreshShopBM.Data.Services.RequestService
{
    public interface IRequestProvider
    {
        Task<TResult> PostAsync<TResult>(string uri, string data, string token = "");

        Task<TResult> PostAsync<TResult>(string uri, ByteArrayContent data, string token = "");
    }
}