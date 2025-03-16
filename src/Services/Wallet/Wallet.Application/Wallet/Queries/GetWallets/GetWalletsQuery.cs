using BuildingBlocks.Pagination;

namespace Wallet.Application.Wallet.Queries.GetWallets;

public record GetWalletsQuery(PaginationRequest PaginationRequest) 
    : IQuery<GetWalletResult>;

public record GetWalletResult(PaginatedResult<WalletDto> Wallets);