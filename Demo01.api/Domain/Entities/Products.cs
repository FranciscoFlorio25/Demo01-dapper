using System.Security.Cryptography.X509Certificates;

namespace Demo01.api.Domain.Entities
{
    public class Products
    {
        public string ProductName { get; set; }
        public float UnitPrice {  get; set; }
        public int Quantity { get; set; }
       public Products(string productName, float unitPrice, int quantity) {
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;

       }
    }
}
