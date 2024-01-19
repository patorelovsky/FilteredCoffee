using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FilteredCoffee;

namespace FilteredCoffee.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<FilteredCoffee.Coffee> Coffee { get; set; } = default!;

public DbSet<FilteredCoffee.Brewing> Brewing { get; set; } = default!;
}
