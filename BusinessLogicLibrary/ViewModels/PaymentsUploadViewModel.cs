using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogicLibrary.ViewModels
{
    public class PaymentsUploadViewModel
    {
        public HttpPostedFileBase CsvFile { get; set; }
        public string AccountId { get; set; }
    }
}
