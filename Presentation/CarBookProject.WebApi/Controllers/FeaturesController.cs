﻿using CarBookProject.Application.Features.Mediator.Commands.FeatureCommands;
using CarBookProject.Application.Features.Mediator.Queries.FeatureQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeaturesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public FeaturesController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> ListFeature()
		{
			var values = await _mediator.Send(new GetFeatureQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetFeature(int id)
		{
			var value = await _mediator.Send(new GetFeatureByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
		{
			await _mediator.Send(command);
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command)
		{
			await _mediator.Send(command);
			return Ok();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteFeature(int id)
		{
			await _mediator.Send(new DeleteFeatureCommand(id));
			return Ok();
		}
	}

}
