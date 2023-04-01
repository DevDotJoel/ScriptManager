using AutoMapper;
using ScriptManager.Application.Common.Exceptions;
using ScriptManager.Application.Common.Interfaces;
using ScriptManager.Application.Common.Models.Script;
using ScriptManager.Domain.Aggregates.ScriptAggregate;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Factory;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Params;
using ScriptManager.Domain.Shared.Interfaces;

namespace ScriptManager.Application.Services
{
    public class ScriptService : IScriptService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IScriptFactory _scriptFactory;
        private readonly IMapper _mapper;
        public ScriptService(IUnitOfWork unitOfWork, IMapper mapper,IScriptFactory _scriptFactory)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ScriptDto> Create(CreateUpdateScriptDto script)
        {
            var currentScript = _scriptFactory.Create(script.Name, script.Description);
            currentScript.AddQuestions(_mapper.Map<List<QuestionParam>>(script.Questions));
            await _unitOfWork.ScriptRepository.AddAsync(currentScript);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ScriptDto>(currentScript);
        }

        public async Task<List<ScriptDto>> GetAll()
        {
            var result = await _unitOfWork.ScriptRepository.GetAll();
            return _mapper.Map<List<ScriptDto>>(result);
        }

        public async Task<ScriptDto> GetById(int id)
        {
            var result = await _unitOfWork.ScriptRepository.GetById(id);
            return _mapper.Map<ScriptDto>(result);
        }

        public async Task<ScriptDto> Update(CreateUpdateScriptDto script)
        {
            throw new NotImplementedException();
            //var currentScript = await _unitOfWork.ScriptRepository.GetById(script.Id);
            //currentScript.UpdateScript(script.Name, script.Description);
            //foreach (var question in script.Questions!)
            //{
            //    if (question.DeleteQuestion)
            //    {
            //        var questionToDelete = currentScript.RemoveQuestion(question.Id);
            //        _unitOfWork.ScriptRepository.DeleteQuestion(questionToDelete);
            //    }
            //    else if (question.Id != 0)
            //    {
            //        var questionToUpdate = currentScript.GetQuestionById(question.Id);
            //        questionToUpdate.UpdateQuestion(question.Number, question.Title, question.Text, question.Type);
            //        foreach (var answer in question.Answers!)
            //        {
            //            if (answer.Id != 0)
            //            {
            //                var currentAnswer = questionToUpdate.GetAnswerById(answer.Id);
            //                if (!string.IsNullOrEmpty(answer.JumpToQuestion))
            //                {
            //                    if (!script.Questions.Any(q => q.Number.Contains(answer.JumpToQuestion, StringComparison.OrdinalIgnoreCase)))
            //                    {
            //                        throw new NotFoundException("question not found");
            //                    }
            //                    else if (question.Number.Contains(answer.JumpToQuestion, StringComparison.OrdinalIgnoreCase))
            //                    {
            //                        throw new NotFoundException("Answer cannot jump to same question");
            //                    }
            //                }
            //                currentAnswer?.UpdateAnswer(answer.Text, answer.JumpToQuestion);
            //            }
            //            else
            //            {
            //                if (!string.IsNullOrEmpty(answer.JumpToQuestion))
            //                {
            //                    if (!script.Questions.Any(q => q.Number.Contains(answer.JumpToQuestion, StringComparison.OrdinalIgnoreCase)))
            //                    {
            //                        throw new NotFoundException("question not found");
            //                    }
            //                    else if (question.Number.Contains(answer.JumpToQuestion, StringComparison.OrdinalIgnoreCase))
            //                    {
            //                        throw new NotFoundException("Answer cannot jump to same question");
            //                    }
            //                }
            //                questionToUpdate.AddAnswer(answer.Text, answer.JumpToQuestion);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        var questionAdded = currentScript.AddQuestion(question.Number, question.Title, question.Text, question.Type);
            //        foreach (var answer in question.Answers!)
            //        {
            //            if (!string.IsNullOrEmpty(answer.JumpToQuestion))
            //            {
            //                if (!script.Questions.Any(q => q.Number.Contains(answer.JumpToQuestion, StringComparison.OrdinalIgnoreCase)))
            //                {
            //                    throw new NotFoundException("question not found");
            //                }
            //                else if (question.Number.Contains(answer.JumpToQuestion, StringComparison.OrdinalIgnoreCase))
            //                {
            //                    throw new NotFoundException("Answer cannot jump to same question");
            //                }
            //            }
            //            questionAdded.AddAnswer(answer.Text, answer.JumpToQuestion);
            //        }
            //    }
            //}
            //_unitOfWork.ScriptRepository.Update(currentScript);
            //await _unitOfWork.SaveChangesAsync();
            //return _mapper.Map<ScriptDto>(currentScript);
        }
    }

}