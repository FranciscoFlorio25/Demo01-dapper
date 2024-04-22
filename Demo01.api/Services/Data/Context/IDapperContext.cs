using System.Data;

namespace Demo01.api.Services.Data.Context
{
    public interface IDapperContext
    {
        public IDbConnection CreateConnection();
    }
}
