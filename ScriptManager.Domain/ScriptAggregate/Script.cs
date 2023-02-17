using ScriptManager.Domain.Common;
using ScriptManager.Domain.Common.Models;
using ScriptManager.Domain.ScriptAggregate.Entities;
using ScriptManager.Domain.ScriptAggregate.Enums;

namespace ScriptManager.Domain.ScriptAggregate
{
    public sealed class Script : Entity<int>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        private readonly List<Question> _questions = new();
        public IReadOnlyList<Question> Questions => _questions.AsReadOnly();
        public Script(string name, string description, List<Question>? questions = null)
        {
            Name = name;
            Description = description;
            _questions = questions ?? new List<Question>();
        }
        private Script()
        {
        }
        public Question AddQuestion(string number, string title, string text, QuestionType type)
        {
            var question = new Question(number, title, text, type, null);
            _questions.Add(question);
            return question;
        }
        public Question GetQuestionById(int questionId)
        {
            var question = Questions.Where(q => q.Id == questionId)!.FirstOrDefault();
            return question;
        }
        public void UpdateScript(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Question RemoveQuestion(int questionId)
        {
            var question = _questions.Where(q => q.Id == questionId)!.FirstOrDefault();
            _questions.Remove(question!);
            return question;
        }
        public bool CheckIfQuestionExists(string number)
        {
            return _questions.Any(q => q.Number.Contains(number.ToLower()));
        }
    }
}