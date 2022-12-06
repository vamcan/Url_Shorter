using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(Guid id)
        {
            Id=id;
        }
        public string UserName { get; set; }
    }
}
