using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    [BsonCollection("users")]
    public class User : BaseEntity
    {
        public User(int id)
        {
            Id=id;
        }
        public string UserName { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
