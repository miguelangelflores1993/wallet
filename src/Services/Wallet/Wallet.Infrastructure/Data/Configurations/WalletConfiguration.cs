using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wallet.Infrastructure.Data.Configurations;
public class WalletConfiguration : IEntityTypeConfiguration<WalletModel>
{
    public void Configure(EntityTypeBuilder<WalletModel> builder)
    {
        builder.HasKey(c => c.Id);
     

        builder.Property(c => c.Name).IsRequired();

        builder.Property(c => c.Balance).IsRequired();

        builder.Property(c => c.DocumentId).IsRequired();
    }
}
