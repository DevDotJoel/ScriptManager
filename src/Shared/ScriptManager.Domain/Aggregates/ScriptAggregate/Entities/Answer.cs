
using ScriptManager.Domain.Shared.Models;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Entities
{
    public class Answer : Entity<int>
    {
        public string? JumpToQuestion { get; private set; }
        public string Text { get; private set; }
        public Answer(string text, string? jumpToQuestion)
        {
            Text = text;
            JumpToQuestion = jumpToQuestion;
        }
        private Answer()
        {
        }
        public void UpdateAnswer(string text, string? jumpToQuestion)
        {
            Text = text;
            JumpToQuestion = jumpToQuestion;
        }
    }
}