namespace ScriptManager.Domain.Common.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAllWithPagination(int page, int size);
        Task AddAsync(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        T Update(T entity);
        T Delete(T entity);
    }
}