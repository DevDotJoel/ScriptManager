using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptManager.Domain.ScriptAggregate.Enums;

namespace ScriptManager.Application.Common.Models.Script
{
    public class CreateUpdateQuestionDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public List<AnswerDto>? Answers { get; set; }
        public bool DeleteQuestion { get; set; }
    }
}
