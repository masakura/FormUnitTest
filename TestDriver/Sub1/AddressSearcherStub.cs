using System.Windows.Forms;
using App1.Sub1;

namespace TestDriver.Sub1
{
    internal sealed class AddressSearcherStub : IAddressSearcher
    {
        public AddressResult Search(IWin32Window parent, IAddressSearchService addressSearchService = null)
        {
            using (var form = new AddressSelectStubForm())
            {
                var result = form.ShowDialog(parent);
                return result == DialogResult.OK ? form.Selected : AddressResult.Empty();
            }
        }
    }
}