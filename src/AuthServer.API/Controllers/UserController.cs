using AuthServer.Application.DTO;
using AuthService.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	private readonly IUserService _userService;

	public UserController(IUserService userService)
	{
		_userService = userService;
	}

	[HttpPost]
	public ActionResult<UserDto> Create([FromBody] UserDto userDto)
	{
		var createdUserDto = _userService.Create(userDto); 
		return Created("api/User", createdUserDto);
	}
}
