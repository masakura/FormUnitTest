using System.Net.Http;
using System.Threading.Tasks;

namespace App1.Sub1
{
    public interface IClient
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}