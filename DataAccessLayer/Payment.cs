using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public PaymentType PaymentTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public AccountType AccountTypeId { get; set; }
        public int AccountId { get; set; }

    }
}
