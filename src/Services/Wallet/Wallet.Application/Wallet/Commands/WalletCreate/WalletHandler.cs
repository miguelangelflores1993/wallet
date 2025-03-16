
namespace Wallet.Application.Wallet.Commands.CreateWallet;
public class CreateWalletHandler(IApplicationDbContext dbContext)
    : ICommandHandler<CreateWalltetCommand, CreateWalletResult>
{
    public async Task<CreateWalletResult> Handle(CreateWalltetCommand command, CancellationToken cancellationToken)
    {


        var wallet = CreateNewWallet(command.Wallet);

        dbContext.WalletModel.Add(wallet);
        await dbContext.SaveChangesAsync(cancellationToken);

        return new CreateWalletResult(wallet.Id.Value);
    }

    private WalletModel CreateNewWallet(WalletDto walletDto)
    {
       
       // TODO: Implementar esta función
             throw new NotImplementedException("Esta función aún no está implementada.");
    }
}
