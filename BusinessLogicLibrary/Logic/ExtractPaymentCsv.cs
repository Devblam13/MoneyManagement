using BusinessLogicLibrary.CsvMaps;
using BusinessLogicLibrary.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogicLibrary.Logic
{
    public class ExtractPaymentCsv
    {
        public List<PaymentDto> Payments { get; private set; }

        public ExtractPaymentCsv(HttpPostedFile file, int accountId)
        {
            using (StreamReader reader = new StreamReader(file.InputStream))
            {
                string content = reader.ReadToEnd();
                using (TextReader textReader = reader)
                {
                    CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(textReader);
                    while(csvReader.Read())
                    {
                        PaymentDto payment = csvReader.GetRecord<PaymentDto>();
                        payment.AccountId = accountId;
                        Payments.Add(payment);
                    }                    
                }
            };            
        }
    }
}
