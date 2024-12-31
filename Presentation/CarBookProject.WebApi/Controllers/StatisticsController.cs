using CarBookProject.Application.Features.Mediator.Queries.StatisticQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StatisticsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public StatisticsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> GetCarCount()
		{
			var values = await _mediator.Send(new GetAllStatisticQuery());
			return Ok(values);
		}

	}

}
