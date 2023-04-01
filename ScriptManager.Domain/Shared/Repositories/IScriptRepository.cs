using ScriptManager.Domain.Aggregates.ScriptAggregate;
using ScriptManager.Domain.Aggregates.ScriptAggregate.Entities;
using ScriptManager.Domain.Shared.Interfaces;

namespace ScriptManager.Domain.Shared.Repositories
{
    public interface IScriptRepository : IBaseRepository<Script>
    {
        void DeleteQuestion(Question question);
    }
}