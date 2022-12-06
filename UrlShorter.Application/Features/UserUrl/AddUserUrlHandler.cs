using MediatR;
using UrlShorter.Application.Contracts.Repository;
using UrlShorter.Application.Models.Common;
using UrlShorter.Domain.Entities;

namespace UrlShorter.Application.Features.UserUrl
{
    public class AddUserUrlHandler : IRequestHandler<AddUserUrlCommand, OperationResult<Domain.Entities.UserUrl>>
    {
        private readonly IRepository<Domain.Entities.UserUrl> _repository;

        public AddUserUrlHandler(IRepository<Domain.Entities.UserUrl> repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Domain.Entities.UserUrl>> Handle(AddUserUrlCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var userUrl = new Domain.Entities.UserUrl()
                {
                    BaseUrl = request.BaseUrl,
                    CreatedTime = DateTime.Now,
                    ShortUrl = new ShortUrl(request.UserId),
                    User = new User(request.UserId),

                };
                await _repository.AddAsync(userUrl,cancellationToken);
                var result = await _repository.SaveChangesAsync(cancellationToken);
                if (result > 0)
                {
                    return OperationResult<Domain.Entities.UserUrl>.SuccessResult(userUrl);
                }
                return OperationResult<Domain.Entities.UserUrl>.FailureResult("Can Not Save");
            }
            catch (Exception e)
            {
                return OperationResult<Domain.Entities.UserUrl>.FailureResult(e.Message);
            }
        }
    }
}
