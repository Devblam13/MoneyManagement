using BusinessLogicLibrary.FilterModels;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.ViewModels
{
    public class LegacysBetViewModel
    {
        public BetFilterModel Filter { get; set; } = new BetFilterModel();

        public List<LegacyBet> Bets { get; set; } = new List<LegacyBet>();
    }
}
