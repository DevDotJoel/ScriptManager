using ScriptManager.Domain.ScriptAggregate.Entities;

namespace ScriptManager.Application.Common.Models.Script
{
    public class ScriptDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<QuestionDto>? Questions { get; set; }
    }
}