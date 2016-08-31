using System;

namespace App1.Sub1
{
    public sealed class Customer : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Prefecture { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }

        object ICloneable.Clone()
        {
            return new Customer
            {
                Id = Id,
                Name = Name,
                PostalCode = PostalCode,
                Prefecture = Prefecture,
                City = City,
                Town = Town,
                Address = Address
            };
        }

        public Customer Clone()
        {
            return (Customer) ((ICloneable) this).Clone();
        }
    }
}