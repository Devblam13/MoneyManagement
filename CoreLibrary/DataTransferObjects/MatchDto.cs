using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataTransferObjects
{
    public class MatchDto
    {
        public int MatchId { get; set; }
        public MatchTeamGoalsDto HomeTeam { get; set; }
        public MatchTeamGoalsDto AwayTeam { get; set; }
        public CompetitionDto Competition { get; set; }
        public DateTime? DateScored { get; set; }
        public DateTime DateOfFixture { get; set; }
    }
}
