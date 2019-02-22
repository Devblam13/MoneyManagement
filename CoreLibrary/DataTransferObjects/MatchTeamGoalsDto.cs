using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataTransferObjects
{
    public class MatchTeamGoalsDto
    {
        public int MatchTeamGoalsId { get; set; }
        public int Goals { get; set; }
        public TeamDto Team { get; set; }
    }
}
