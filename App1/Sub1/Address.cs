namespace App1.Sub1
{
    public sealed class AddressResult
    {
        private AddressResult(bool isSuccess, string postalCode, string prefecture, string city, string town)
        {
            IsSuccess = isSuccess;
            PostalCode = postalCode;
            Prefecture = prefecture;
            City = city;
            Town = town;
        }

        public string PostalCode { get; }
        public string Prefecture { get; }
        public string City { get; }
        public bool IsSuccess { get; }
        public string Town { get; }

        public static AddressResult Success(string postalCode, string prefecture, string city, string town)
        {
            return new AddressResult(true, postalCode, prefecture, city, town);
        }

        public override string ToString()
        {
            return $"IsSuccess: {IsSuccess}, PostalCode: {PostalCode}, Prefecture: {Prefecture}, City: {City}, Town: {Town}";
        }

        public static AddressResult Empty()
        {
            return new AddressResult(false, null, null, null, null);
        }
    }
}