using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataTransferObjects
{
    public class MatchBetDto
    {
        public int MatchBetId { get; set; }
        public MatchDto Match { get; set; }
        public BetType BetType { get; set; }
        public decimal Odds { get; set; }
    }
}
