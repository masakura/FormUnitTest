using System;
using System.Threading.Tasks;
using App1.Sub1;

namespace TestDriver.Sub1
{
    internal sealed class AddressSearchServiceStub : IAddressSearchService
    {
        public Task<AddressResult> Search(string postalCode)
        {
            if (postalCode == "0000000")
            {
                return Task.FromResult(AddressResult.Success("0000000", "鹿児島県", "鹿児島市", "名山町"));
            }
            if (postalCode == "0000001")
            {
                throw new InvalidOperationException("サーバーに接続できませんでした");
            }

            return Task.FromResult(AddressResult.Empty());
        }
    }
}