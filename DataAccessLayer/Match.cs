using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Match
    {
        public int MatchId { get; set; }
        public MatchTeamGoals HomeTeam { get; set; }
        public MatchTeamGoals AwayTeam { get; set; }
        public Competition Competition { get; set; }
        public DateTime? DateScored { get; set; }
        public DateTime DateOfFixture { get; set; }
    }
}
