using MediatR;
using UrlShorter.Application.Models.Common;

namespace UrlShorter.Application.Features.UserUrl
{
    public class AddUserUrlCommand: IRequest<OperationResult<Domain.Entities.UserUrl>>
    {
        public int UserId { get; set; }
        public int ShortUrlId { get; set; }
        public string BaseUrl { get; set; }
    }
}
