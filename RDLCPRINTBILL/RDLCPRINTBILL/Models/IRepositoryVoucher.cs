using RDLCPRINTBILL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RDLCPRINTBILL.Models
{
    public interface IRepositoryVoucher
    {
        Task<IEnumerable<VoucherDetail>> GetVoucherDetail();
    }
}