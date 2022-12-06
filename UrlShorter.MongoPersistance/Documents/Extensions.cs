using UrlShorter.Domain.Entities;

namespace UrlShorter.MongoPersistance.Documents
{
    internal static class Extensions
    {
        public static UserUrl AsEntity(this UserUrlDocument document)
            => new UserUrl()
            {
                BaseUrl = document.BaseUrl,
                ShortUrl = new ShortUrl(document.ShortUrl.Id)
                {
                    Status = document.ShortUrl.Status,
                    UrlKey = document.ShortUrl.UrlKey,
                },
                User = new User(document.User.Id)
                {
                    UserName = document.User.UserName,
                    CreatedTime = document.User.RecordDate,
                }

            };



    }
}
