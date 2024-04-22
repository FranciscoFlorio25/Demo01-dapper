using Dapper;
using Demo01.api.Domain.Entities;
using Demo01.api.DTO.CustomerDTO;
using Demo01.api.DTO.ProductsDTO;
using Demo01.api.Services.Data.Context;
using Demo01.api.Services.Data.Repository;
using System.Data;
using System.Reflection.Metadata;

namespace Demo01.api.Application.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDapperContext _context;

        public ProductRepository(IDapperContext context)
        {
            _context = context;
        }


        public async Task<ProductsListDTO> GetProducts(int orderId)
        {
            var procedureName = "GetProductOrder";

            var connection = _context.CreateConnection();

            var parameters = new { orderId = orderId };

            var products = await connection.QueryAsync<Products>(procedureName, parameters, commandType: CommandType.StoredProcedure);

            if (!products.Any() || products == null)
            {
                return null;
            }
            var productsList = products.Select(x => new ProductDTO(x.ProductName, x.UnitPrice, x.Quantity));

            return new ProductsListDTO(productsList);

        }
    }
}
