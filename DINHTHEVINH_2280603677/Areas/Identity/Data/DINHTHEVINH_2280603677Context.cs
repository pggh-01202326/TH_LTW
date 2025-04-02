using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DINHTHEVINH_2280603677.Data;

public class DINHTHEVINH_2280603677Context : IdentityDbContext<IdentityUser>
{
    public DINHTHEVINH_2280603677Context(DbContextOptions<DINHTHEVINH_2280603677Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
