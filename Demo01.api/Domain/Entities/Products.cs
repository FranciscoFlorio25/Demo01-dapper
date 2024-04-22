using System.Security.Cryptography.X509Certificates;

namespace Demo01.api.Domain.Entities
{
    public class Products
    {
        public string ProductName { get; set; }
        public decimal UnitPrice {  get; set; }
        public Int16 Quantity { get; set; }
       public Products(string productName, decimal unitPrice, Int16 quantity) {
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;

       }
    }
}
