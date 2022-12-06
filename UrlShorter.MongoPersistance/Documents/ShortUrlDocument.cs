using UrlShorter.Domain.Common;
using UrlShorter.Domain.Entities;

namespace UrlShorter.MongoPersistance.Documents
{
    public class ShortUrlDocument 
    {
        public Guid Id { get; set; }
        public string UrlKey { get; set; }
        public ShortUrlStatus Status { get; set; }
    }

    
}
