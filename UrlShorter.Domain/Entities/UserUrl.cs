using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    [BsonCollection("userUrls")]
    public class UserUrl:BaseEntity
    {
        public User User { get; set; }
        public ShortUrl ShortUrl { get; set; }
        public string BaseUrl { get; set; }
    }
}
