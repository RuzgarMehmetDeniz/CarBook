using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResutl>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResutl>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResutl
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl
            }).ToList();

        }
    }
}
