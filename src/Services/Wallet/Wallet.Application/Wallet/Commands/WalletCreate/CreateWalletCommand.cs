using BuildingBlocks.CQRS;
using FluentValidation;
using Wallet.Application.Dtos;

namespace Wallet.Application.Wallet.Commands.CreateWallet;

public record CreateWalltetCommand(WalletDto Wallet)
    : ICommand<CreateWalletResult>;

public record CreateWalletResult(Guid Id);

public class CreateWallteCommandValidator : AbstractValidator<CreateWalltetCommand>
{
    public CreateWallteCommandValidator()
    {
        RuleFor(x => x.Wallet.Balance).NotEmpty().WithMessage("is required");
        RuleFor(x => x.Wallet.DocumentId).NotNull().WithMessage(" is required");
        RuleFor(x => x.Wallet.Name).NotEmpty().WithMessage(" should not be empty");
    }
}