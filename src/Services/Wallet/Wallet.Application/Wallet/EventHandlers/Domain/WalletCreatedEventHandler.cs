using MassTransit;
using Microsoft.FeatureManagement;

namespace Wallet.Application.Wallet.EventHandlers.Domain;
public class WalletCreatedEventHandler
    (IPublishEndpoint publishEndpoint, IFeatureManager featureManager, ILogger<WalletCreatedEventHandler> logger)
    : INotificationHandler<WalletCreatedEvent>
{
    public async Task Handle(WalletCreatedEvent domainEvent, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", domainEvent.GetType().Name);

        if (await featureManager.IsEnabledAsync("WalletFullfilment"))
        {
            var walletCreatedIntegrationEvent = domainEvent.wallet.ToWalletDto();
            await publishEndpoint.Publish(walletCreatedIntegrationEvent, cancellationToken);
        }
    }
}
