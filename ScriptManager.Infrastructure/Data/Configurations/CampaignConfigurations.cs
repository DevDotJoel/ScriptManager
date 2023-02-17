using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptManager.Domain.ScriptAggregate;
using ScriptManager.Domain.CampaignAggregate;
using ScriptManager.Domain.CampaignAggregate.ValueObjects;

namespace ScriptManager.Infrastructure.Data.Configurations
{
    public class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            ConfigureCampaignsTable(builder);
        }

        private static void ConfigureCampaignsTable(EntityTypeBuilder<Campaign> builder)
        {
            builder.ToTable("Campaigns");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Description);
            builder.Property(s => s.Name);
            builder.HasOne<Script>().WithMany().HasForeignKey(x => x.ScriptId);
        }
    }
}