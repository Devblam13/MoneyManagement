namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_IdentityColumnInsert : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MatchBets", "Bet_BetId", "dbo.Bets");
            DropForeignKey("dbo.MatchBets", "MatchBetId", "dbo.Matches");
            DropForeignKey("dbo.Matches", "MatchId", "dbo.MatchTeamGoals");
            DropIndex("dbo.Bets", new[] { "BetId" });
            DropIndex("dbo.MatchBets", new[] { "MatchBetId" });
            DropIndex("dbo.Matches", new[] { "MatchId" });
            DropIndex("dbo.MatchTeamGoals", new[] { "MatchTeamGoalsId" });
            DropIndex("dbo.LegacyBets", new[] { "LegacyBetId" });
            DropPrimaryKey("dbo.Bets");
            DropPrimaryKey("dbo.MatchBets");
            DropPrimaryKey("dbo.Matches");
            DropPrimaryKey("dbo.MatchTeamGoals");
            DropPrimaryKey("dbo.LegacyBets");
            AlterColumn("dbo.Bets", "BetId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.MatchBets", "MatchBetId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Matches", "MatchId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.MatchTeamGoals", "MatchTeamGoalsId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.LegacyBets", "LegacyBetId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bets", "BetId");
            AddPrimaryKey("dbo.MatchBets", "MatchBetId");
            AddPrimaryKey("dbo.Matches", "MatchId");
            AddPrimaryKey("dbo.MatchTeamGoals", "MatchTeamGoalsId");
            AddPrimaryKey("dbo.LegacyBets", "LegacyBetId");
            CreateIndex("dbo.Bets", "BetId");
            CreateIndex("dbo.MatchBets", "MatchBetId");
            CreateIndex("dbo.Matches", "MatchId");
            CreateIndex("dbo.MatchTeamGoals", "MatchTeamGoalsId");
            CreateIndex("dbo.LegacyBets", "LegacyBetId");
            AddForeignKey("dbo.MatchBets", "Bet_BetId", "dbo.Bets", "BetId");
            AddForeignKey("dbo.MatchBets", "MatchBetId", "dbo.Matches", "MatchId");
            AddForeignKey("dbo.Matches", "MatchId", "dbo.MatchTeamGoals", "MatchTeamGoalsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "MatchId", "dbo.MatchTeamGoals");
            DropForeignKey("dbo.MatchBets", "MatchBetId", "dbo.Matches");
            DropForeignKey("dbo.MatchBets", "Bet_BetId", "dbo.Bets");
            DropIndex("dbo.LegacyBets", new[] { "LegacyBetId" });
            DropIndex("dbo.MatchTeamGoals", new[] { "MatchTeamGoalsId" });
            DropIndex("dbo.Matches", new[] { "MatchId" });
            DropIndex("dbo.MatchBets", new[] { "MatchBetId" });
            DropIndex("dbo.Bets", new[] { "BetId" });
            DropPrimaryKey("dbo.LegacyBets");
            DropPrimaryKey("dbo.MatchTeamGoals");
            DropPrimaryKey("dbo.Matches");
            DropPrimaryKey("dbo.MatchBets");
            DropPrimaryKey("dbo.Bets");
            AlterColumn("dbo.LegacyBets", "LegacyBetId", c => c.Int(nullable: false));
            AlterColumn("dbo.MatchTeamGoals", "MatchTeamGoalsId", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "MatchId", c => c.Int(nullable: false));
            AlterColumn("dbo.MatchBets", "MatchBetId", c => c.Int(nullable: false));
            AlterColumn("dbo.Bets", "BetId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.LegacyBets", "LegacyBetId");
            AddPrimaryKey("dbo.MatchTeamGoals", "MatchTeamGoalsId");
            AddPrimaryKey("dbo.Matches", "MatchId");
            AddPrimaryKey("dbo.MatchBets", "MatchBetId");
            AddPrimaryKey("dbo.Bets", "BetId");
            CreateIndex("dbo.LegacyBets", "LegacyBetId");
            CreateIndex("dbo.MatchTeamGoals", "MatchTeamGoalsId");
            CreateIndex("dbo.Matches", "MatchId");
            CreateIndex("dbo.MatchBets", "MatchBetId");
            CreateIndex("dbo.Bets", "BetId");
            AddForeignKey("dbo.Matches", "MatchId", "dbo.MatchTeamGoals", "MatchTeamGoalsId");
            AddForeignKey("dbo.MatchBets", "MatchBetId", "dbo.Matches", "MatchId");
            AddForeignKey("dbo.MatchBets", "Bet_BetId", "dbo.Bets", "BetId");
        }
    }
}
