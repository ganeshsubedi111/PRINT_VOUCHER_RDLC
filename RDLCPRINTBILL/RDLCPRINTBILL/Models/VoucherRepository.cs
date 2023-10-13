
using Dapper;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace RDLCPRINTBILL.Models
{
    public class VoucherRepository : IRepositoryVoucher
    {
        private readonly string _connectionString;

        public VoucherRepository(IOptions<AppDbConnection> config)
        {
            _connectionString = config.Value.ConnectionString;
        }

        public async Task<IEnumerable<VoucherDetail>> GetVoucherDetail()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Open();

                string query = "SELECT title, remarks, DrAmount, CrAmount FROM VoucherDetail";
                return await db.QueryAsync<VoucherDetail>(query, commandType: CommandType.Text);
            }
        }
    }
}
        

