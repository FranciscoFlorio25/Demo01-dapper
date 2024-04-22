using Dapper;
using Demo01.api.Domain.Entities;
using Demo01.api.DTO.CustomerDTO;
using Demo01.api.DTO.ProductsDTO;
using Demo01.api.Services.Data.Context;
using Demo01.api.Services.Data.Repository;
using System.Data;

namespace Demo01.api.Application.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDapperContext _context;

        public CustomerRepository(IDapperContext context)
        {
            _context = context;
        }
        public async Task<CustomerDTO> GetCustomerNameAddress(int orderId)
        {
            var procedureName = "GetCustomer";

            var connection = _context.CreateConnection();

            var customer = await connection.QueryFirstOrDefaultAsync<Customer>(procedureName, orderId, commandType: CommandType.StoredProcedure);

            if (customer == null)
            {
                return null;
            }

            return new CustomerDTO(customer.CustomerName, customer.Address);
        }

    }
}
