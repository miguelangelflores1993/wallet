namespace Wallet.Domain.ValueObjects;

public record WalletId(Guid Value)
{
    public static WalletId New() => new WalletId(Guid.NewGuid());
}
