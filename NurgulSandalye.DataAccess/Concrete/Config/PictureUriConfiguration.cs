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
    public class PictureUriConfiguration : IEntityTypeConfiguration<PictureUri>
    {
        public void Configure(EntityTypeBuilder<PictureUri> builder)
        {
            builder.Property(x => x.Uri).IsRequired();

            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);
        }
    }
}
