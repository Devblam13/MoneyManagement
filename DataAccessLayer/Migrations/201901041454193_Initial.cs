namespace DataAccessLayer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.BetImages",
                c => new
                    {
                        BetImageId = c.Int(nullable: false, identity: true),
                        Image = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.BetImageId);
            
            CreateTable(
                "dbo.Bets",
                c => new
                    {
                        BetId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DatePlaced = c.DateTime(nullable: false),
                        Outcome = c.Boolean(),
                        AccountTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BetId)
                .ForeignKey("dbo.BetImages", t => t.BetId)
                .Index(t => t.BetId);
            
            CreateTable(
                "dbo.MatchBets",
                c => new
                    {
                        MatchBetId = c.Int(nullable: false),
                        BetType = c.Int(nullable: false),
                        Odds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bet_BetId = c.Int(),
                    })
                .PrimaryKey(t => t.MatchBetId)
                .ForeignKey("dbo.Matches", t => t.MatchBetId)
                .ForeignKey("dbo.Bets", t => t.Bet_BetId)
                .Index(t => t.MatchBetId)
                .Index(t => t.Bet_BetId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchId = c.Int(nullable: false),
                        DateScored = c.DateTime(),
                        DateOfFixture = c.DateTime(nullable: false),
                        Competition_CompetitionId = c.Int(),
                    })
                .PrimaryKey(t => t.MatchId)
                .ForeignKey("dbo.MatchTeamGoals", t => t.MatchId)
                .ForeignKey("dbo.Competitions", t => t.Competition_CompetitionId)
                .Index(t => t.MatchId)
                .Index(t => t.Competition_CompetitionId);
            
            CreateTable(
                "dbo.MatchTeamGoals",
                c => new
                    {
                        MatchTeamGoalsId = c.Int(nullable: false),
                        Goals = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchTeamGoalsId)
                .ForeignKey("dbo.Teams", t => t.MatchTeamGoalsId)
                .Index(t => t.MatchTeamGoalsId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 100,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "TeamName",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { Name: TeamName, IsUnique: True }")
                                },
                            }),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        CompetitionId = c.Int(nullable: false, identity: true),
                        Name = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "Name",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { Name: Name, IsUnique: True }")
                                },
                            }),
                    })
                .PrimaryKey(t => t.CompetitionId);
            
            CreateTable(
                "dbo.LegacyBets",
                c => new
                    {
                        LegacyBetId = c.Int(nullable: false),
                        DatePlaced = c.DateTime(nullable: false),
                        IsWin = c.Boolean(nullable: false),
                        TotalOdds = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PotentialReturn = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AccountId = c.Int(nullable: false),
                        AccountType = c.Int(nullable: false),
                        LosingTeamOdd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalSelections = c.Int(nullable: false),
                        LosingTeam_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.LegacyBetId)
                .ForeignKey("dbo.BetImages", t => t.LegacyBetId)
                .ForeignKey("dbo.Teams", t => t.LosingTeam_TeamId)
                .Index(t => t.LegacyBetId)
                .Index(t => t.LosingTeam_TeamId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTypeId = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        AccountTypeId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LegacyBets", "LosingTeam_TeamId", "dbo.Teams");
            DropForeignKey("dbo.LegacyBets", "LegacyBetId", "dbo.BetImages");
            DropForeignKey("dbo.MatchBets", "Bet_BetId", "dbo.Bets");
            DropForeignKey("dbo.MatchBets", "MatchBetId", "dbo.Matches");
            DropForeignKey("dbo.Matches", "Competition_CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Matches", "MatchId", "dbo.MatchTeamGoals");
            DropForeignKey("dbo.MatchTeamGoals", "MatchTeamGoalsId", "dbo.Teams");
            DropForeignKey("dbo.Bets", "BetId", "dbo.BetImages");
            DropIndex("dbo.LegacyBets", new[] { "LosingTeam_TeamId" });
            DropIndex("dbo.LegacyBets", new[] { "LegacyBetId" });
            DropIndex("dbo.MatchTeamGoals", new[] { "MatchTeamGoalsId" });
            DropIndex("dbo.Matches", new[] { "Competition_CompetitionId" });
            DropIndex("dbo.Matches", new[] { "MatchId" });
            DropIndex("dbo.MatchBets", new[] { "Bet_BetId" });
            DropIndex("dbo.MatchBets", new[] { "MatchBetId" });
            DropIndex("dbo.Bets", new[] { "BetId" });
            DropTable("dbo.Payments");
            DropTable("dbo.LegacyBets");
            DropTable("dbo.Competitions",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "Name", "IndexAnnotation: { Name: Name, IsUnique: True }" },
                        }
                    },
                });
            DropTable("dbo.Teams",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "TeamName",
                        new Dictionary<string, object>
                        {
                            { "TeamName", "IndexAnnotation: { Name: TeamName, IsUnique: True }" },
                        }
                    },
                });
            DropTable("dbo.MatchTeamGoals");
            DropTable("dbo.Matches");
            DropTable("dbo.MatchBets");
            DropTable("dbo.Bets");
            DropTable("dbo.BetImages");
            DropTable("dbo.Accounts");
        }
    }
}
