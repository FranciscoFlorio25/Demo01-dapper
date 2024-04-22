using Demo01.api.Services.Data.Context;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Demo01.api.Infraestructure.Context
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Default")!;
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

    }
}
