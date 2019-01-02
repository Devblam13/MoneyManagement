using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MatchTeamGoals
    {
        public int MatchTeamGoalsId { get; set; }
        public int Goals { get; set; }
        public Team Team { get; set; }
    }
}
