using BusinessLogicLibrary.FilterModels;
using CoreLibrary.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.ViewModels
{
    public class PaymentsViewModel
    {
        public PaymentsFilterModel Filter { get; set; } = new PaymentsFilterModel();

        public List<PaymentDto> Payments { get; set; } = new List<PaymentDto>();

        public PaymentsViewModel()
        {

        }
    }
}
