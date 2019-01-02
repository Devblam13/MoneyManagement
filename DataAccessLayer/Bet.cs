using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Bet
    {
        public int BetId { get; set; }
        public List<MatchBet> MatchBets { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePlaced { get; set; }
        public BetImage Image { get; set; }
        public bool? Outcome { get; set; }
        public AccountType AccountTypeId { get; set; }

    }
}
