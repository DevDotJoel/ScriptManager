using Microsoft.EntityFrameworkCore.Storage;
using ScriptManager.Domain.Shared.Interfaces;
using ScriptManager.Domain.Shared.Repositories;
using ScriptManager.Infrastructure.Data;
using ScriptManager.Infrastructure.Repositories;

namespace ScriptManager.Infrastructure.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ScriptManagerContext _context;
        public ICampaignRepository CampaignRepository { get; private set; }

        public IScriptRepository ScriptRepository { get; private set; }
        private IDbContextTransaction _transaction;

        public UnitOfWork(ScriptManagerContext context)
        {
            _context = context;
            CampaignRepository = new CampaignRepository(_context);
            ScriptRepository = new ScriptRepository(_context);

        }
        public Task BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public Task CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}