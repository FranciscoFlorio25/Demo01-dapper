using Demo01.api.DTO.CustomerDTO;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.api.Services.Data.Repository
{
    public interface ICustomerRepository
    {
        public Task<CustomerDTO> GetCustomerNameAddress(int OrderId);
    }
}
