using CoreLibrary.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Logic
{
    public class BetCalculationHelper
    {
        public BetDto Bet { get; private set; }

        private decimal _totalOdds;

        public decimal TotalOdds
        {
            get
            {
                if (_totalOdds == 0)
                {
                    _totalOdds = GetTotalOdds();
                }

                return _totalOdds;
            }
        }

        public BetCalculationHelper(BetDto bet)
        {
            Bet = bet;
        }

        private decimal GetTotalOdds()
        {
            decimal odds = 1;
            var oddsList = Bet.MatchBets.Select(x => x.Odds).ToArray();
            for (int i = 0; i < oddsList.Length; i++)
            {
                odds *= oddsList[i];
            }
            return odds;
        }

        public decimal GetPotential()
        {            
            return _totalOdds * Bet.Amount;            
        }

    }
}
