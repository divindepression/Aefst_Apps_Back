namespace Aefst.Apps.Core.Abstractions
{
    public interface IRepository<T,k> where T : class
    {
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(Guid Id);
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> GetByName(string name);
    }
}
