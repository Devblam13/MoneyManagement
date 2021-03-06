﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using CoreLibrary.DataTransferObjects;

namespace BusinessLogicLibrary.Logic
{
    public class ResultDecider
    {
        public MatchBetDto MatchBet { get; private set; }

        public ResultDecider(MatchBetDto matchBet)
        {
            MatchBet = matchBet;
        }

        public bool? IsMatchAWin()
        {

            if(MatchBet.Match.DateScored == null)
            {
                return null;
            }

            bool? isWin = false;

            int homeGoals = MatchBet.Match.HomeTeam.Goals;
            int awayGoals = MatchBet.Match.AwayTeam.Goals;

            switch (MatchBet.BetType)
            {
                case BetType.ResultHome90:
                    if (homeGoals > awayGoals)
                    {
                        isWin = true;
                    }
                    break;
                case BetType.ResultDraw90:
                    if (homeGoals == awayGoals)
                    {
                        isWin = true;
                    }
                    break;
                case BetType.ResultAway90:
                    if (homeGoals < awayGoals)
                    {
                        isWin = true;
                    }
                    break;
                case BetType.BothTeamsToScoreYes:
                    if(homeGoals > 0 && awayGoals > 0)
                    {
                        isWin = true;
                    }
                    break;
                case BetType.BothTeamsToScoreNo:
                    if(homeGoals == 0 || awayGoals == 0)
                    {
                        isWin = true;
                    }
                    break;
                case BetType.BothTeamsToScoreAndResultHome:
                    if(homeGoals > 0 && awayGoals > 0)
                    {
                        if(homeGoals > awayGoals)
                        {
                            isWin = true;
                        }
                    }
                    break;
                case BetType.BothTeamsToScoreAndResultDraw:
                    if (homeGoals > 0 && awayGoals > 0)
                    {
                        if (homeGoals == awayGoals)
                        {
                            isWin = true;
                        }
                    }
                    break;

                case BetType.BothTeamsToScoreAndResultAway:
                    if (homeGoals > 0 && awayGoals > 0)
                    {
                        if (homeGoals < awayGoals)
                        {
                            isWin = true;
                        }
                    }
                    break;
                case BetType.Under3:
                    if((homeGoals + awayGoals) < 3)
                    {
                        isWin = true;
                    }
                    break;
                case BetType.Over3:
                    if((homeGoals + awayGoals) > 2)
                    {
                        isWin = true;
                    }
                    break;
                default:
                    isWin = null;
                    break;
            }
            return isWin;
        }
    }
}
