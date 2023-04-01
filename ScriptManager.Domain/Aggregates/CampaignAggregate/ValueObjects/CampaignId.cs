using ScriptManager.Domain.Shared.Models;

namespace ScriptManager.Domain.Aggregates.CampaignAggregate.ValueObjects
{
    public class CampaignId : ValueObject
    {
        public int Value { get; private set; }
        public CampaignId(int value)
        {
            Value = value;
        }
        public static CampaignId Create(int value)
        {
            return new CampaignId(value);
        }
        public static CampaignId Create()
        {
            return new CampaignId(0);
        }
    }
}