using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NurgulSandalye.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurgulSandalye.DataAccess.Concrete.Config
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.Property(x => x.BuyerId).IsRequired().HasMaxLength(40);
            builder.HasMany(x => x.Items).WithOne().HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
