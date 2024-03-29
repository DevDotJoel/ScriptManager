
using ScriptManager.Domain.Shared.Models;

namespace ScriptManager.Domain.Aggregates.CampaignAggregate
{
    public class Campaign : Entity<int>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int? ScriptId { get; private set; }

        private Campaign(string name, string description, int? scriptId = null)
        {
            Name = name;
            Description = description;
            ScriptId = scriptId;
        }
    }
}