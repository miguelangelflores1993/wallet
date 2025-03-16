
namespace Wallet.Application.Dtos;

public record WalletDto(
    Guid Id,
    string DocumentId,
    string Name,
    decimal Balance,
    DateTime CreatedAt,
    DateTime UpdatedAt
   
    );
