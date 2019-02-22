using AutoMapper;
using CoreLibrary.DataTransferObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.AutoMap
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Bet, BetDto>().ReverseMap();
            CreateMap<Competition, CompetitionDto>().ReverseMap();
            CreateMap<BetImage, BetImageDto>().ReverseMap();
            CreateMap<LegacyBet, LegacyBetDto>().ReverseMap();
            CreateMap<MatchBet, MatchBetDto>().ReverseMap();
            CreateMap<Match, MatchDto>().ReverseMap();
            CreateMap<MatchTeamGoals, MatchTeamGoalsDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<Team, TeamDto>().ReverseMap();
        }
    }
}
