using ScriptManager.Domain.Common.Interfaces;
using ScriptManager.Domain.ScriptAggregate;
using ScriptManager.Domain.ScriptAggregate.Entities;

namespace ScriptManager.Domain.Common.Repositories
{
    public interface IScriptRepository : IBaseRepository<Script>
    {
        void DeleteQuestion(Question question);
    }
}