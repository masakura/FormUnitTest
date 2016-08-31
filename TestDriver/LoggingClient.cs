using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using App1.Sub1;

namespace TestDriver
{
    internal sealed class LoggingClient : IClient
    {
        private readonly IClient _parent;

        public LoggingClient(IClient parent)
        {
            _parent = parent;
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            Debug.WriteLine(url);

            try
            {
                var response = await _parent.GetAsync(url);

                await WriteLine(response);

                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                throw;
            }
        }

        private async Task WriteLine(HttpResponseMessage response)
        {
            try
            {
                Debug.WriteLine(response.StatusCode);
                Debug.WriteLine(await response.Content.ReadAsStringAsync());

                return;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                // ログ出力時の例外は続行させる
            }
        }
    }
}