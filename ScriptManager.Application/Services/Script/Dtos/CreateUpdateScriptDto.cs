using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Application.Common.Models.Script
{
    public class CreateUpdateScriptDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CreateUpdateQuestionDto>? Questions { get; set; }
    }
}
