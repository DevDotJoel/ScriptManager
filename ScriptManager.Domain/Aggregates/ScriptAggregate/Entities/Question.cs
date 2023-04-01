using ScriptManager.Domain.Aggregates.ScriptAggregate.Enums;
using ScriptManager.Domain.Shared.Models;
using System.Xml.Linq;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Entities
{
    public sealed class Question : Entity<int>
    {
        public string Number { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public QuestionType Type { get; private set; }
        private readonly List<Answer> _answers = new();
        public IReadOnlyList<Answer> Answers => _answers.AsReadOnly();
        public Question(string number, string title, string text, QuestionType type, List<Answer>? answers = null)
        {
            Number = number;
            Title = title;
            Text = text;
            Type = type;
            _answers = answers ?? new List<Answer>();
        }
        private Question()
        {
        }
        public void UpdateQuestion(string number, string title, string text, QuestionType type)
        {
            Number = number;
            Title = title;
            Text = text;
            Type = type;
        }
        public void AddAnswer(string text, string? jumpToQuestion)
        {
            var answer = new Answer(text, jumpToQuestion);
            _answers.Add(answer);
        }

        public Answer GetAnswerById(int answerId)
        {
            var answer = Answers.Where(a => a.Id == answerId)!.FirstOrDefault();
            return answer;
        }
        public void RemoveAnswer(int answerId)
        {
            var answer = _answers.Find(a => a.Id == answerId);
            if (answer is not null)
            {
                _answers.Remove(answer);
            }
        }
    }
}