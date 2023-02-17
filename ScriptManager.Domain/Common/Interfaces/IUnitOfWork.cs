using ScriptManager.Domain.Common.Repositories;

namespace ScriptManager.Domain.Common.Interfaces
{
    public interface IUnitOfWork
    {
        ICampaignRepository CampaignRepository { get; }
        IScriptRepository ScriptRepository { get; }
        Task SaveChangesAsync();
        Task BeginTransaction();
        Task CommitTransaction();
    }
}