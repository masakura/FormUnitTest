using System;
using System.Threading.Tasks;

namespace App1.Sub1
{
    internal sealed class AddressSearchServiceImpl : IAddressSearchService
    {
        public static IAddressSearchService Current { get; } = new AddressSearchServiceImpl();

        public Task<AddressResult> Search(string postalCode)
        {
            throw new NotImplementedException("Not Implemented");
        }
    }
}