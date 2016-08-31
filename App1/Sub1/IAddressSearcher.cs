using System.Windows.Forms;

namespace App1.Sub1
{
    public interface IAddressSearcher
    {
        AddressResult Search(IWin32Window parent, IAddressSearchService addressSearchService = null);
    }
}