using ScriptManager.Domain.Aggregates.ScriptAggregate.Entities;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Enums;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Models;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Params;
using ScriptManager.Domain.Shared.Models;
namespace ScriptManager.Domain.Aggregates.ScriptAggregate
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
        public void AddQuestions(List<QuestionParam> questions)
        {
            foreach (var currentQuestion in questions)
            {
                if(!CheckIfQuestionExists(currentQuestion.Number))
                {
                    var question = new Question(currentQuestion.Number, currentQuestion.Title, currentQuestion.Text, currentQuestion.Type, null);
                    foreach (var currentAnswer in currentQuestion.Answers)
                    {
                        if (!string.IsNullOrEmpty(currentAnswer.JumpToQuestion))
                        {
                            if (CheckIfQuestionExists(currentAnswer.JumpToQuestion))
                            {
                                throw new Exception("question not found");
                            }
                            else if (question.Number.Contains(currentAnswer.JumpToQuestion, StringComparison.OrdinalIgnoreCase))
                            {
                                throw new Exception("Answer cannot jump to same question");
                            }
                        }

                        question.AddAnswer(currentAnswer.Text, currentAnswer.JumpToQuestion);

                    }
                    _questions.Add(question);
                }

            }
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
        private bool CheckIfQuestionExists(string number)
        {
            return _questions.Any(q => q.Number.Contains(number.ToLower(), StringComparison.OrdinalIgnoreCase));
        }

    }
}