using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTo.Infrastructure.Configurations
{
    public class ToToContext
    {
        private readonly string _connectionString;

        public ToToContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Develop")!;
        }


        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
