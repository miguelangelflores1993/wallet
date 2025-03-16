using BuildingBlocks.Exceptions;

namespace Wallet.Application.Exceptions;
public class WalletNotFoundException : NotFoundException
{
    public WalletNotFoundException(Guid id) : base("Wallet", id)
    {
    }
}
