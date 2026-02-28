using AuthServer.Application.DTO;

namespace AuthService.Application.Services.Interfaces;

public interface IUserService
{
	public Task<IEnumerable<UserDto>> getAll();
	public Task<UserDto> getById();
	public UserDto Create(UserDto userDto);
	public UserDto Update(UserDto userDto);
	public void Delete(UserDto userDto);
}
