using BusinessLogicLibrary.FilterModels;
using DataAccessLayer;
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

        public List<Payment> Payments { get; set; } = new List<Payment>();

        public PaymentsViewModel()
        {

        }
    }
}
