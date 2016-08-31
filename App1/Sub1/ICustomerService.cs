using System.Threading.Tasks;

namespace App1.Sub1
{
    public interface ICustomerService
    {
        Task<Customer[]> GetCustomers();
        Task<Customer> GetCustomer(int id);
    }
}