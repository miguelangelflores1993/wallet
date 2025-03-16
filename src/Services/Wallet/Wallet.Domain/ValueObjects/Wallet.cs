namespace Wallet.Domain.ValueObjects;

public record Wallet
{
    public int Id { get; init; }
    public string DocumentId { get; } = default!;
    public string Name { get; } = default!;
    public decimal Balance { get; private set; }
    public DateTime CreatedAt { get; } = default!;
    public DateTime UpdatedAt { get; private set; }

    protected Wallet() { }

    private Wallet(int id, string documentId, string name, decimal balance, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        DocumentId = documentId;
        Name = name;
        Balance = balance;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    public static Wallet Create(string documentId, string name, decimal initialBalance)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(documentId);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        return new Wallet(
            id: 0, // Será autoincremental en la BD
            documentId: documentId,
            name: name,
            balance: initialBalance,
            createdAt: DateTime.UtcNow,
            updatedAt: DateTime.UtcNow
        );
    }

    public Wallet UpdateBalance(decimal newBalance)
    {
        return this with
        {
            Balance = newBalance,
            UpdatedAt = DateTime.UtcNow
        };
    }
}
