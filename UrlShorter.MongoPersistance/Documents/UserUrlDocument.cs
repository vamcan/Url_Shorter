using UrlShorter.Domain.Common;

namespace UrlShorter.MongoPersistance.Documents
{
    public class UserUrlDocument
    {
        public Guid Id { get; set; }
        public UserDocument User { get; set; }
        public ShortUrlDocument ShortUrl { get; set; }
        public string BaseUrl { get; set; }
    }
}
