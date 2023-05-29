using MagpulShop.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magpul.Persistence.EntityTypeConfigurations
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(basket => basket.Id);
            builder.HasIndex(basket => basket.Id).IsUnique();
        }        
    }
}
