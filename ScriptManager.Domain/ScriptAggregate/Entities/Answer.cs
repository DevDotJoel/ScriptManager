using ScriptManager.Domain.Common;
using ScriptManager.Domain.Common.Interfaces;
using ScriptManager.Domain.Common.Models;

namespace ScriptManager.Domain.ScriptAggregate.Entities
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