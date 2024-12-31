using CarBookProject.Application.Interfaces.RentACarInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBookProject.Persistence.Repositories.RentACarRepositories
{
	public class RentACarRepository : IRentACarRepository
	{
		private readonly CarBookContext _context;

		public RentACarRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
		{
			var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(x => x.CarPricings).Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.Location).ToListAsync();
			return values;
		}
	}
}
