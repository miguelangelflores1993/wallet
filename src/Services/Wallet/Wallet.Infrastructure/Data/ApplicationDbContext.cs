using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Models;
using System.Reflection;
using Wallet.Application.Data;

namespace Wallet.Infrastructure.Data;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) { }

    public DbSet<WalletModel> WalletModel => Set<WalletModel>();


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
