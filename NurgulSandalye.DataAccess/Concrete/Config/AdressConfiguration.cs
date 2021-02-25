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
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.Property(a => a.City).IsRequired().HasMaxLength(100);
            builder.Property(a => a.District).IsRequired().HasMaxLength(180);
            builder.Property(a => a.LongAdress).IsRequired().HasMaxLength(300);
            builder.Property(a => a.ZipCode).IsRequired().HasMaxLength(18);
        }
    }
}
