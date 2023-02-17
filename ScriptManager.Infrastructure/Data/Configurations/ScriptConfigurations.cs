using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScriptManager.Domain.ScriptAggregate;

namespace ScriptManager.Infrastructure.Data.Configurations
{
    public class ScriptConfiguration : IEntityTypeConfiguration<Script>
    {
        public void Configure(EntityTypeBuilder<Script> builder)
        {
            ConfigureScriptsTable(builder);
            ConfigureQuestionsTable(builder);
        }

        private static void ConfigureScriptsTable(EntityTypeBuilder<Script> builder)
        {
            builder.ToTable("Scripts");
            builder.HasKey(s => s.Id);
            builder.Property(q => q.Name);
            builder.Property(q => q.Description);
        }
        private static void ConfigureQuestionsTable(EntityTypeBuilder<Script> builder)
        {
            builder.OwnsMany(s => s.Questions, qb =>
          {
              qb.HasKey(s => s.Id);
              qb.ToTable("Questions");
              qb.Property(q => q.Number);
              qb.Property(q => q.Text);
              qb.Property(q => q.Title);
              qb.Property(q => q.Type);
              qb.WithOwner().HasForeignKey("ScriptId");
              qb.OwnsMany(q => q.Answers, ab =>
              {
                  ab.HasKey(s => s.Id);
                  ab.ToTable("Answers");
                  ab.WithOwner().HasForeignKey("QuestionId");
              });
              qb.Navigation(q => q.Answers).Metadata.SetField("_answers");
              qb.Navigation(q => q.Answers).UsePropertyAccessMode(PropertyAccessMode.Field);
          });
            builder.Metadata.FindNavigation(nameof(Script.Questions))!.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
