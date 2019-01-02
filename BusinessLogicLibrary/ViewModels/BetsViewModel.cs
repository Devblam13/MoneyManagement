using BusinessLogicLibrary.FilterModels;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.ViewModels
{
    public class BetsViewModel
    {
        public List<Bet> Bets { get; set; } = new List<Bet>();

        public BetFilterModel Filter { get; set; } = new BetFilterModel();


    }
}
