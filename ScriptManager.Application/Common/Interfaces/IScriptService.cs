using ScriptManager.Application.Common.Models.Script;

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