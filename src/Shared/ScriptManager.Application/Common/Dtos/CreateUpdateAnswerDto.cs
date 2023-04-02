using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Application.Common.Dtos
{
    public class CreateUpdateAnswerDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string? JumpToQuestion { get; set; }
        public bool DeleteAnswer { get; set; }
    }
}
