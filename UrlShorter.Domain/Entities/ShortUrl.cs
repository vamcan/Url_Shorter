using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShorter.Domain.Common;

namespace UrlShorter.Domain.Entities
{
    public class ShortUrl : BaseEntity
    {
        public string UrlKey { get; set; }
        public ShortUrlStatus Status { get; set; }
    }

    public enum ShortUrlStatus
    {
        NotSold,
        Sold
    }
}
