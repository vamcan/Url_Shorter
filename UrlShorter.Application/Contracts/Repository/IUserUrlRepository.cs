
using UrlShorter.Domain.Entities;

namespace UrlShorter.Application.Contracts.Repository
{
    public interface IUserUrlRepository
    {
        Task<UserUrl> GetAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task AddAsync(UserUrl userUrl);
        Task UpdateAsync(UserUrl userUr);
        Task DeleteAsync(int id);
    }
}
