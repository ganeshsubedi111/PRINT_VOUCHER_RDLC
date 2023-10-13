using EBILINGPRINTRDLC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EBILINGPRINTRDLC.Models
{



    public partial class VoucherDetail
    {

        public string PARTICULARS { get; set; }


        public string MEMO { get; set; }

        public decimal DR_AMOUNT { get; set; }

        public decimal CR_AMOUNT { get; set; }
    }
}

