using Microsoft.EntityFrameworkCore;
using ScriptManager.Domain.Common.Repositories;
using ScriptManager.Domain.ScriptAggregate;
using ScriptManager.Domain.ScriptAggregate.Entities;
using ScriptManager.Infrastructure.Data;

namespace ScriptManager.Infrastructure.Repositories
{

    public class ScriptRepository : IScriptRepository
    {
        private readonly ScriptManagerContext _context;
        public ScriptRepository(ScriptManagerContext context)
        {
            _context = context;

        }
        public async Task AddAsync(Script entity)
        {
            await _context.Scripts.AddAsync(entity);
        }

        public Script Delete(Script entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuestion(Question question)
        {
            _context.Remove(question);
        }

        public async Task<List<Script>> GetAll()
        {
            return await _context.Scripts.AsNoTracking().ToListAsync();
        }

        public Task<List<Script>> GetAllWithPagination(int page, int size)
        {
            throw new NotImplementedException();
        }

        public async Task<Script> GetById(int id)
        {
            return await _context.Scripts.Where(s => s.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public Script Update(Script entity)
        {
            _context.Scripts.Update(entity);
            return entity;
        }
    }
}