namespace Wallet.Domain.Models;

public class WalletModel : Entity<WalletId>
{
    public string DocumentId { get; private set; } = default!;
    public string Name { get; private set; } = default!;
    public decimal Balance { get; private set; } = default!;
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    private WalletModel() { }

    public static WalletModel Create(WalletId id, string documentId, string name, decimal initialBalance)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(documentId);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentOutOfRangeException.ThrowIfNegative(initialBalance);

        return new WalletModel
        {
            Id = id,
            DocumentId = documentId,
            Name = name,
            Balance = initialBalance,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }

    public void UpdateBalance(decimal newBalance)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(newBalance);

        Balance = newBalance;
        UpdatedAt = DateTime.UtcNow;
    }
}
