namespace Wallet.Domain.Events;

public record WalletCreatedEvent(WalletModel wallet) : IDomainEvent;
