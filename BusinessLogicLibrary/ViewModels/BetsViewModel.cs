using BusinessLogicLibrary.FilterModels;
using CoreLibrary.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.ViewModels
{
    public class BetsViewModel
    {
        public List<BetDto> Bets { get; set; } = new List<BetDto>();

        public BetFilterModel Filter { get; set; } = new BetFilterModel();


    }
}
