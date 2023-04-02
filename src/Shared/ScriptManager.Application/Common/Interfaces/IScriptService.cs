using ScriptManager.Application.Common.Dtos;

namespace ScriptManager.Application.Common.Interfaces
{

    public interface IScriptService
    {
        Task<ScriptDto> Create(CreateUpdateScriptDto script);
        Task<ScriptDto> Update(CreateUpdateScriptDto script);
        Task<ScriptDto> GetById(int id);
        Task<List<ScriptDto>> GetAll();
    }
}