using BuildingBlocks.Pagination;

namespace Wallet.Application.Wallet.Queries.GetWallets;
public class GetWalletsHandler(IApplicationDbContext dbContext)
    : IQueryHandler<GetWalletsQuery, GetWalletResult>
{
    public async Task<GetWalletResult> Handle(GetWalletsQuery query, CancellationToken cancellationToken)
    {
    

        var pageIndex = query.PaginationRequest.PageIndex;
        var pageSize = query.PaginationRequest.PageSize;

        var totalCount = await dbContext.WalletModel.LongCountAsync(cancellationToken);

        var wallets = await dbContext.WalletModel
                       .OrderBy(o => o.DocumentId)
                       .Skip(pageSize * pageIndex)
                       .Take(pageSize)
                       .ToListAsync(cancellationToken);

        return new GetWalletResult(
            new PaginatedResult<WalletDto>(
                pageIndex,
                pageSize,
                totalCount,
                wallets.ToWalletDtoList()));        
    }
}
