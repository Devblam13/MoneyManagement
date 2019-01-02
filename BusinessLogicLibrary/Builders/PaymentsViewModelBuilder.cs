using BusinessLogicLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLibrary.Builders
{
    public class PaymentsViewModelBuilder
    {
        public int AccountId { get; private set; }
        public PaymentsViewModelBuilder(int accountId)
        {
            AccountId = accountId;
        }
    }
}
