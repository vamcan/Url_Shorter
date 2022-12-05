using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    public class UserUrl:BaseEntity
    {
        public User User { get; set; }
        public ShortUrl ShortUrl { get; set; }
        public string BaseUrl { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
