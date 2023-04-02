using AutoMapper;
using ScriptManager.Application.Common.Dtos;
using ScriptManager.Application.Common.Exceptions;
using ScriptManager.Application.Common.Interfaces;
using ScriptManager.Domain.Aggregates.ScriptAggregate;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Params;
using ScriptManager.Domain.Shared.Interfaces;

namespace ScriptManager.Application.Services
{
    public class ScriptService : IScriptService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ScriptService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ScriptDto> Create(CreateUpdateScriptDto script)
        {
            var currentScript = Script.Create(script.Name, script.Description);
            currentScript.AddOrUpdateQuestions(_mapper.Map<List<QuestionParam>>(script.Questions));
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
            var currentScript = await _unitOfWork.ScriptRepository.GetById(script.Id);
            currentScript.UpdateScript(script.Name, script.Description);
            currentScript.AddOrUpdateQuestions(_mapper.Map<List<QuestionParam>>(script.Questions));
            _unitOfWork.ScriptRepository.Update(currentScript);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ScriptDto>(currentScript);
        }
    }

}