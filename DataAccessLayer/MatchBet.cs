using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MatchBet
    {
        public int MatchBetId { get; set; }
        public Match Match { get; set; }
        public BetType BetType { get; set; }
        public decimal Odds { get; set; }

    }
}
