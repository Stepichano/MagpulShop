using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagpulShop.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;

namespace EntityTypeConfiguration
{
    public class SubProductCategoryConfiguration : IEntityTypeConfiguration<SubProductCategory>
    {
        public void Configure(EntityTypeBuilder<SubProductCategory> builder)
        {
            builder.HasKey(subProductCategory => subProductCategory.Id);
            builder.HasIndex(subProductCategory => subProductCategory.Id).IsUnique();
            builder.HasOne(subProductCategory => subProductCategory.ProductCategory);
        }
    }
}
