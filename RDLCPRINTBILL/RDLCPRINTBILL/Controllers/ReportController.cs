using AspNetCore.Reporting;
using RDLCPRINTBILL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RDLCPRINTBILL.Controllers
{
    public class ReportController : Controller
    {
        private readonly IRepositoryVoucher _voucherRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportController(IWebHostEnvironment webHostEnvironment, IRepositoryVoucher voucherRepository)
        {
            _webHostEnvironment = webHostEnvironment;
            _voucherRepository = voucherRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public async Task<IActionResult> IndexAsync()
        {
            string mimeType = "application/pdf";
            int extension = 1;
            var path = Path.Combine(_webHostEnvironment.WebRootPath, "Reports", "Voucher.rdlc");
            
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("CompanyName", "Janapriya Multiple Campus");
            parameters.Add("Address", "Simalchour-8, Pokhara");
            parameters.Add("vtype", "JOURNAL VOUCHER");
            parameters.Add("CostCenter", "Main");
            parameters.Add("DATEN", "2080-8-23");
            parameters.Add("Vcode", "234");
            parameters.Add("Narration", "Being Paid Amount to Mr. Anunnya Baral from Cheque No:39667472");
            parameters.Add("pby", "Kumar Gurung");
            var Voucher = await _voucherRepository.GetVoucherDetail();
            

            

            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("DataSet1", Voucher);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(result.MainStream, mimeType);
        }
    }
}

