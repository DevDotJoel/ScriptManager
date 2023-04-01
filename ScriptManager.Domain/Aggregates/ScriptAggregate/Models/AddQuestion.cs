using ScriptManager.Domain.Aggregates.ScriptAggregate.Entities;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Models
{
    public class AddQuestion
    {
        public string Number { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public List<AddAnswer> Answers { get; set; }
    }
}