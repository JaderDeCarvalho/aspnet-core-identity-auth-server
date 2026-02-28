using AuthServer.Application.DTO;
using AuthServer.Domain.Repositories;
using AuthService.Application.Services.Interfaces;

namespace AuthServer.Application.Services;

public class UserService : IUserService
{
	private readonly IUserRepository _userRepository;

	public UserService(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public Task<IEnumerable<UserDto>> getAll()
	{
		throw new NotImplementedException();
	}

	public Task<UserDto> getById()
	{
		throw new NotImplementedException();
	}
	
	public UserDto Create(UserDto userDto)
	{
		throw new NotImplementedException();
	}

	public UserDto Update(UserDto userDto)
	{
		throw new NotImplementedException();
	}

	public void Delete(UserDto userDto)
	{
		throw new NotImplementedException();
	}
}
