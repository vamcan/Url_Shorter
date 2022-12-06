using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    public class UserUrl:BaseEntity
    {
        public User User { get; set; }
        public ShortUrl ShortUrl { get; set; }
        public string BaseUrl { get; set; }
    }
}
