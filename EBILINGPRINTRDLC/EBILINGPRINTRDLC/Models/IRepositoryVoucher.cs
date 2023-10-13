using EBILINGPRINTRDLC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EBILINGPRINTRDLC.Models
{
    public interface IRepositoryVoucher
    {
        Task<IEnumerable<VoucherDetail>> GetVoucherDetail();
    }
}