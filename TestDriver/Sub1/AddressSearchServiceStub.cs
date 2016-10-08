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
                return Address("0000000", "宮崎県", "宮崎市", "宮崎");
            if (postalCode == "0000001")
                return Address("0000001", "鹿児島県", "鹿児島市", "名山町");
            if (postalCode == "0000002")
                return Address("0000002", "とにかくですね", "長い長い長い長い", "住所字とかいろいろはいっててめっちゃながい");
            if (postalCode == "9999999")
            {
                throw new InvalidOperationException("サーバーに接続できませんでした");
            }
            return Task.FromResult(AddressResult.Empty());
        }

        private Task<AddressResult> Address(string postalCode, string prefecture, string city, string town)
        {
            return Task.FromResult(AddressResult.Success(postalCode, prefecture, city, town));
        }
    }
}