using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    public class ShortUrl : BaseEntity
    {
        public ShortUrl(Guid id)
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
