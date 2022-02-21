namespace MySportsClub.Models
{
    public interface IRepository<T> where T : class
    {

        Task<IEnumerable<T>> FindAllAsync();
        Task<T> FindAsync(int id);

        Task InsertAsync(T item);
        Task DeleteAsync(T item);
        Task UpdateAsync(T item);
    }
}
