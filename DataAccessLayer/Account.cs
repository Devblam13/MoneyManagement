using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Account
    {
        public int AccountId { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
