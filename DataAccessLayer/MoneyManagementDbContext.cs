namespace DataAccessLayer
{
    using DataAccessLayer.FluentConfigurations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MoneyManagementDbContext : DbContext
    {
        // Your context has been configured to use a 'MoneyManagementDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataAccessLayer.MoneyManagementDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MoneyManagementDbContext' 
        // connection string in the application configuration file.
        public MoneyManagementDbContext()
            : base("name=MoneyManagementDbContext")
        {
            Database.SetInitializer<MoneyManagementDbContext>(new CreateDatabaseIfNotExists<MoneyManagementDbContext>());

        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<BetImage> BetImages { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchBet> MatchBets { get; set; }
        public DbSet<MatchTeamGoals> MatchTeamGoals { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<LegacyBet> LegacyBets { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountEntityConfiguration());
            modelBuilder.Configurations.Add(new BetEntityConfiguration());
            modelBuilder.Configurations.Add(new BetImageEntityConfiguration());
            modelBuilder.Configurations.Add(new CompetitionEntityConfiguration());
            modelBuilder.Configurations.Add(new MatchBetEntityConfiguration());
            modelBuilder.Configurations.Add(new MatchEntityConfiguration());
            modelBuilder.Configurations.Add(new MatchTeamGoalsEntityConfiguration());
            modelBuilder.Configurations.Add(new PaymentEntityConfiguration());
            modelBuilder.Configurations.Add(new TeamEntityConfiguration());
            modelBuilder.Configurations.Add(new LegacyBetEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}