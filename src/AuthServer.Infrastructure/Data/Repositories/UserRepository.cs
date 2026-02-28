using AuthServer.Domain.Entities;
using AuthServer.Domain.Repositories;

namespace AuthServer.Infrastructure.Data.Repositories;

public class UserRepository : IUserRepository
{
	public Task<IEnumerable<User>> getAll()
	{
		throw new NotImplementedException();
	}

	public Task<User> getById()
	{
		throw new NotImplementedException();
	}
	
	public User Create(User user)
	{
		throw new NotImplementedException();
	}

	public User Update(User user)
	{
		throw new NotImplementedException();
	}

	public void Delete(User user)
	{
		throw new NotImplementedException();
	}
}
