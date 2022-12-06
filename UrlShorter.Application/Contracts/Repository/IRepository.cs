using UrlShorter.Application.Base;

namespace UrlShorter.Application.Contracts.Repository
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class
    {
    }
}
