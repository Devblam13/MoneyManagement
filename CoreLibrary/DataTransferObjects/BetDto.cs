using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataTransferObjects
{
    public class BetDto
    {

        public int BetId { get; set; }
        public List<MatchBetDto> MatchBets { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePlaced { get; set; }
        public BetImageDto Image { get; set; }
        public bool? Outcome { get; set; }
        public AccountType AccountTypeId { get; set; }
    }
}
