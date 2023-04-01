using ScriptManager.Domain.Aggregates.CampaignAggregate;
using ScriptManager.Domain.Shared.Repositories;
using ScriptManager.Infrastructure.Data;

namespace ScriptManager.Infrastructure.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly ScriptManagerContext _context;
        public CampaignRepository(ScriptManagerContext context)
        {
            _context = context;
        }
        public Task AddAsync(Campaign entity)
        {
            throw new NotImplementedException();
        }

        public Campaign Delete(Campaign entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Campaign>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Campaign>> GetAllWithPagination(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<Campaign> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Campaign Update(Campaign entity)
        {
            throw new NotImplementedException();
        }
    }
}