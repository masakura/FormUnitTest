using System.Threading.Tasks;

namespace App1.Sub1
{
    public interface IAddressSearchService
    {
        Task<AddressResult> Search(string postalCode);
    }
}