using MagpulShop.Domain.Entitys;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityTypeConfiguration
{
    public class DiskountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(discount => discount.Id);
            builder.HasIndex(discount => discount.Id).IsUnique();
        }
    }
}
