using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.Infrastructure;

public class DbContext : IdentityDbContext<IdentityUser>
{
	public DbContext(DbContextOptions<DbContext> options) :
		base(options)
	{}
}
