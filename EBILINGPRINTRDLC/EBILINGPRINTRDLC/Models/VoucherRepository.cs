
using Dapper;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EBILINGPRINTRDLC.Models
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

                string query = "SELECT PARTICULARS, MEMO, DR_AMOUNT, CR_AMOUNT FROM VoucherDetail";
                return await db.QueryAsync<VoucherDetail>(query, commandType: CommandType.Text);
            }
        }
    }
}
        

