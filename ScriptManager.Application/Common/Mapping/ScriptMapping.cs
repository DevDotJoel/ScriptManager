using AutoMapper;
using ScriptManager.Application.Common.Models.Script;
using ScriptManager.Domain.ScriptAggregate;
using ScriptManager.Domain.ScriptAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Application.Common.Mapping
{
    public class ScriptMapping : Profile
    {
        public ScriptMapping()
        {
            CreateMap<Script, ScriptDto>();
            CreateMap<Question, QuestionDto>();
            CreateMap<Answer, AnswerDto>();
        }
    }
}
