using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;
public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasKey(i => i.Id);
        builder.ToTable("Models");
        builder.Property(m => m.DailyPrice).HasColumnType("decimal(10, 2)");  // 'DailyPrice' sütununun tipini belirleme: 8 basamaklı tam ve virgülden sonra 2 basamaklı sayı ile Toplam: 10 Basamaklı sayı. Örn: 12.345.678,12
    }
}
