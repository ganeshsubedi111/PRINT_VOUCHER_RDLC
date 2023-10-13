using RDLCPRINTBILL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RDLCPRINTBILL.Models
{



    public partial class VoucherDetail
    {

        public string title { get; set; }


        public string remarks { get; set; }

        public decimal DrAmount { get; set; }

        public decimal CrAmount { get; set; }
    }
}

