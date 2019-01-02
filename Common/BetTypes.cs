using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public enum BetType
    {
        ResultHome90 = 1,
        ResultDraw90 = 2,
        ResultAway90 = 3,
        BothTeamsToScoreYes = 4,
        BothTeamsToScoreNo = 5,
        BothTeamsToScoreAndResultHome = 6,
        BothTeamsToScoreAndResultDraw = 7,
        BothTeamsToScoreAndResultAway = 8,
        Under3 = 9,
        Over3 = 10
    }
}
