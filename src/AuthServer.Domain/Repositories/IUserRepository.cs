using AuthServer.Domain.Entities;

namespace AuthServer.Domain.Repositories;

public interface IUserRepository
{
	public Task<IEnumerable<User>> getAll();
	public Task<User> getById();
	public User Create(User user);
	public User Update(User user);
	public void Delete(User user);
}
