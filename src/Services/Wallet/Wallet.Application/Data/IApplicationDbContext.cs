using Microsoft.EntityFrameworkCore;
using Wallet.Domain.Models;
namespace Wallet.Application.Data;
public interface IApplicationDbContext
{
    DbSet<WalletModel> WalletModel { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
