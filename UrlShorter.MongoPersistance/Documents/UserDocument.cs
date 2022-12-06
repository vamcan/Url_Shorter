using UrlShorter.Domain.Common;

namespace UrlShorter.MongoPersistance.Documents
{
    public class UserDocument 
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
