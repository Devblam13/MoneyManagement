using CommonLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.FilterModels
{
    public class BetFilterModel
    {
        public bool IsWinner { get; set; }
        public decimal TotalOddsFrom { get; set; }
        public decimal TotalOddsTo { get; set; }

        public Team LosingTeam { get; set; } = new Team();
        public decimal PotentialReturnFrom { get; set; }
        public decimal PotentialReturnTo { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int NumberOfSelectionsFrom { get; set; }
        public int NumberOfSelectionsTo { get; set; }
        public AccountType AccountType { get; set; }

        public BetFilterModel()
        {
            IsWinner = true;
            TotalOddsFrom = 1;
            TotalOddsTo = 10000;
            PotentialReturnFrom = 0;
            PotentialReturnTo = 100000;
            DateFrom = new DateTime(1, 1, 2000);
            DateTo = DateTime.Today.AddDays(1);
            AccountType = CommonLibrary.AccountType.All;
            NumberOfSelectionsFrom = 1;
            NumberOfSelectionsTo = 100;

        }
    }
}