using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LegacyBet
    {
        public int LegacyBetId { get; set; }

        public DateTime DatePlaced { get; set; }

        public bool IsWin { get; set; }

        public decimal TotalOdds { get; set; }

        public BetImage Image { get; set; }

        public decimal PotentialReturn { get; set; }

        public int AccountId { get; set; }

        public AccountType AccountType { get; set; }

        public Team LosingTeam { get; set; }

        public decimal LosingTeamOdd { get; set; }

        public int TotalSelections { get; set; }        
    }
}
