using UrlShorter.Application.Base;

namespace UrlShorter.Application.Contracts.Repository
{
    public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class
    {
    }
}
