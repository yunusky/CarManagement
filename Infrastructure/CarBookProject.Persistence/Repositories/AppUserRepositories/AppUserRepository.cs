using CarBookProject.Application.Interfaces.AppUserInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBookProject.Persistence.Repositories.AppUserRepositories
{
	public class AppUserRepository : IAppUserRepository
	{
		private readonly CarBookContext _context;

		public AppUserRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
		{
			var values = await _context.AppUsers.Where(filter).ToListAsync();
			return values;
		}
	}
}
