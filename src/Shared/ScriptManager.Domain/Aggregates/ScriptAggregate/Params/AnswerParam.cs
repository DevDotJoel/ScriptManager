using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Params
{
    public class AnswerParam
    {
        public int Id { get; set; }
        public string? JumpToQuestion { get;  set; }
        public string Text { get;  set; }
        public bool DeleteAnswer { get; set; }
    }
}
