using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using BusinessLogicLibrary.DataTransferObjects;

namespace BusinessLogicLibrary.CsvMaps
{
    public class PaymentsCsvMap : ClassMap<PaymentDto>
    {
        public PaymentsCsvMap()
        {
            AutoMap();
        }
    }
}
