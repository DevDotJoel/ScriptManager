using AutoMapper;
using ScriptManager.Application.Common.Dtos;
using ScriptManager.Domain.Aggregates.ScriptAggregate;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Entities;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Params;
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
            CreateMap<CreateUpdateQuestionDto, QuestionParam>();
            CreateMap<CreateUpdateAnswerDto, AnswerParam>();
        }
    }
}
