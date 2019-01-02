using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.FilterModels
{
    public class PaymentsFilterModel
    {
        public decimal LowerAmount { get; set; }
        public decimal UpperAmount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public AccountType AccountType { get; set; }
        public PaymentType PaymentType { get; set; }

        public PaymentsFilterModel()
        {
            DateFrom = new DateTime(1, 1, 2000);
            DateTo = DateTime.Today.AddDays(1);
            AccountType = CommonLibrary.AccountType.All;
            LowerAmount = 0;
            PaymentType = CommonLibrary.PaymentType.All;
            UpperAmount = 1000;
        }
    }
}
