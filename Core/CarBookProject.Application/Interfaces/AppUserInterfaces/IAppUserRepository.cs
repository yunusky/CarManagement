using CarBookProject.Domain.Entities;
using System.Linq.Expressions;

namespace CarBookProject.Application.Interfaces.AppUserInterfaces
{
	public interface IAppUserRepository
	{
		Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);
	}
}
