using Wallet.Application.Wallet.Commands.CreateWallet;

namespace Wallet.API.Endpoints;


public record CreateWalletRequest(WalletDto Wallet);
public record CreateWalletResponse(Guid Id);

public class CreateWallet : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/wallet", async (CreateWalletRequest request, ISender sender) =>
        {
            var command = request.Adapt<CreateWalltetCommand>();

            var result = await sender.Send(command);

            var response = result.Adapt<CreateWalletResponse>();

            return Results.Created($"/wallets/{response.Id}", response);
        })
        .WithName("CreateWallet")
        .Produces<CreateWalletResponse>(StatusCodes.Status201Created)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Create Wallet")
        .WithDescription("Create Wallet");
    }
}