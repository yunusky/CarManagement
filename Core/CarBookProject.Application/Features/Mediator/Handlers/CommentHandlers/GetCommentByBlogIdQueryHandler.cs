﻿
using CarBookProject.Application.Features.Mediator.Queries.CommentQueries;
using CarBookProject.Application.Features.Mediator.Results.CommentResults;
using CarBookProject.Application.Interfaces.CommentInterfaces;
using MediatR;

namespace CarBookProject.Application.Features.Mediator.Handlers.CommentHandlers
{
	public class GetCommentByBlogIdQueryHandler : IRequestHandler<GetCommentByBlogIdQuery, List<GetCommentByBlogIdQueryResult>>
	{
		private readonly ICommentRepository _repository;

		public GetCommentByBlogIdQueryHandler(ICommentRepository repository)
		{
			_repository = repository;
		}

		public Task<List<GetCommentByBlogIdQueryResult>> Handle(GetCommentByBlogIdQuery request, CancellationToken cancellationToken)
		{
			var value = _repository.GetCommentListByBlogId(request.Id);
			var result = value.Select(x => new GetCommentByBlogIdQueryResult
			{
				BlogId = x.BlogId,
				CommentId = x.CommentId,
				CreatedDate = x.CreatedDate,
				Name = x.Name,
				Surname = x.Surname,
				Text = x.Text,
				Email = x.Email,
				BlogTitle = x.Blog.Title,
			}).ToList();
			return Task.FromResult(result);
		}
	}
}
