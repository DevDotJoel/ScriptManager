using ScriptManager.Domain.Shared.Repositories;

namespace ScriptManager.Domain.Shared.Interfaces
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