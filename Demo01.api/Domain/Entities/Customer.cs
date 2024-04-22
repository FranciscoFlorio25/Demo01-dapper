namespace Demo01.api.Domain.Entities
{
    public class Customer
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }

        public Customer(string companyName, string address)
        {
            CompanyName = companyName;
            Address = address;
        }
    }
}
