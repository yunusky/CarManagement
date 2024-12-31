﻿using CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public TestimonialsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> ListTestimonial()
		{
			var values = await _mediator.Send(new GetTestimonialQuery());
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetTestimonial(int id)
		{
			var value = await _mediator.Send(new GetTestimonialByIdQuery(id));
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
		{
			await _mediator.Send(command);
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
		{
			await _mediator.Send(command);
			return Ok();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTestimonial(int id)
		{
			await _mediator.Send(new DeleteTestimonialCommand(id));
			return Ok();
		}
	}
}
