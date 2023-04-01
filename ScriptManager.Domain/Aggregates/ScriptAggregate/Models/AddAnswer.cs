using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Models
{
    public class AddAnswer
    {
        public string? JumpToQuestion { get; private set; }
        public string Text { get; private set; }
    }
}
