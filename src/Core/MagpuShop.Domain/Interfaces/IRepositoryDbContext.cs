using MagpulShop.Domain.Entitys;

namespace MagpulShop.Domain.Interfaces
{
    public interface IRepositoryDbContext<T> : IDisposable
            where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        public void SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
