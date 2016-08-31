using System.Windows.Forms;

namespace App1.Sub1
{
    public sealed class AddressSearcherImpl : IAddressSearcher
    {
        public static IAddressSearcher Current { get; } = new AddressSearcherImpl();

        public AddressResult Search(IWin32Window parent, IAddressSearchService addressSearchService = null)
        {
            return AddressSearchForm.Search(parent, addressSearchService);
        }
    }
}