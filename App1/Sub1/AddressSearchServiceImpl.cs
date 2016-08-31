using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;

namespace App1.Sub1
{
    public sealed class AddressSearchServiceImpl : IAddressSearchService
    {
        private readonly IClient _client;

        public AddressSearchServiceImpl(IClient client = null)
        {
            _client = client ?? HttpClientWrapper.Current;
        }

        public static IAddressSearchService Current { get; } = new AddressSearchServiceImpl();

        public async Task<AddressResult> Search(string postalCode)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["lang"] = "ja";
            query["zipcode"] = postalCode;

            var response = await _client.GetAsync($"http://api.zipaddress.net/?{query}");
            var json = await response.Content.ReadAsStringAsync();
            dynamic o = JObject.Parse(json);

            if (o.code == "200")
            {
                dynamic data = o.data;
                return AddressResult.Success(postalCode, (string) data.pref, (string) data.city, (string) data.town);
            }

            return AddressResult.Empty();
        }
    }
}