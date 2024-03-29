using Microsoft.EntityFrameworkCore;
using ScriptManager.Domain.Aggregates.CampaignAggregate;
using ScriptManager.Domain.Aggregates.ScriptAggregate;

namespace ScriptManager.Infrastructure.Data
{
    public class ScriptManagerContext : DbContext
    {
        public ScriptManagerContext(DbContextOptions<ScriptManagerContext> options) : base(options)
        {
        }
        public DbSet<Script> Scripts { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ScriptManagerContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}