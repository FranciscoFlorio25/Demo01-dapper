using Demo01.api.Domain.Entities;
using Demo01.api.DTO.ProductsDTO;

namespace Demo01.api.Services.Data.Repository
{
    public interface IProductRepository
    {
        public Task<ProductsListDTO> GetProducts(int orderId);
    }
}
