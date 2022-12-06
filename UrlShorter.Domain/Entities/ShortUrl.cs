using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    [BsonCollection("shortUrls")]
    public class ShortUrl : BaseEntity
    {
        public ShortUrl(int id)
        {
            Id=id;
        }
        public string UrlKey { get; set; }
        public ShortUrlStatus Status { get; set; }
    }

    public enum ShortUrlStatus
    {
        NotSold,
        Sold
    }
}
