using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Sub1
{
    internal sealed class CustomerServiceImpl : ICustomerService
    {
        private readonly CustomerCollection _customers = new CustomerCollection
        {
            Customer(1, "ばくはつ一郎", "1111111", "北海道", "どこ", "そこ", "1-2-3"),
            Customer(2, "ばくはつ次郎", "1111112", "東京都", "どこ", "そこ", "1-2-3"),
            Customer(3, "ばくはつ三郎", "1111113", "岐阜県", "どこ", "そこ", "1-2-3"),
            Customer(4, "ばくはつ史郎", "1111114", "福岡県", "どこ", "そこ", "1-2-3"),
            Customer(5, "ばくはつ五郎", "1111115", "鹿児島県", "どこ", "そこ", "1-2-3")
        };

        public static ICustomerService Current { get; } = new CustomerServiceImpl();

        public Task<Customer[]> GetCustomers()
        {
            return Task.FromResult(_customers.Select(c => c.Clone()).ToArray());
        }

        public Task<Customer> GetCustomer(int id)
        {
            return Task.FromResult(_customers[id]);
        }

        private static Customer Customer(int id,
            string name,
            string postalCode,
            string prefecture,
            string city,
            string town,
            string address)
        {
            return new Customer
            {
                Id = id,
                Name = name,
                PostalCode = postalCode,
                Prefecture = prefecture,
                City = city,
                Town = town,
                Address = address
            };
        }

        private sealed class CustomerCollection : KeyedCollection<int, Customer>
        {
            protected override int GetKeyForItem(Customer item)
            {
                return item.Id;
            }
        }
    }
}