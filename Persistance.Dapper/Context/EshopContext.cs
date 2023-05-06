using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Dapper.Context
{
    public class EshopContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public EshopContext(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._connectionString = _configuration.GetConnectionString("EshopConnectionString");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(this._connectionString);
    }
}
