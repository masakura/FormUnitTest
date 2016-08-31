using System;
using System.Diagnostics;
using System.Threading.Tasks;
using App1.Sub1;

namespace TestDriver.Sub1
{
    internal sealed class LoggingAddressSearchService : IAddressSearchService
    {
        private readonly IAddressSearchService _parent;

        public LoggingAddressSearchService(IAddressSearchService parent)
        {
            _parent = parent;
        }

        public async Task<AddressResult> Search(string postalCode)
        {
            Debug.WriteLine(postalCode);

            try
            {
                var result = await _parent.Search(postalCode);

                Debug.WriteLine(result);

                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                throw;
            }
        }
    }
}