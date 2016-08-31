using System.Net.Http;
using System.Threading.Tasks;

namespace App1.Sub1
{
    public sealed class HttpClientWrapper : IClient
    {
        private HttpClientWrapper()
        {
        }

        public static IClient Current { get; set; } = new HttpClientWrapper();

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetAsync(url);
            }
        }
    }
}