namespace Demo01.api.Domain.Entities
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public Customer(string customerName, string address)
        {
            CustomerName = customerName;
            Address = address;
        }
    }
}
