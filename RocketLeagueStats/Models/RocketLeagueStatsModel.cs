namespace RocketLeagueStats.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RocketLeagueStatsModel : DbContext
    {
        public RocketLeagueStatsModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<player> players { get; set; }
        public virtual DbSet<team> teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<player>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<team>()
                .Property(e => e.region)
                .IsUnicode(false);
        }
    }
}
