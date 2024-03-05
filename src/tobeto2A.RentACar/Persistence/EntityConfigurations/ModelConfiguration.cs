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

        // TODO: Burada veritabanı ile ilgili bir sorun oluşuyor ise foreign keyleri açıkça belirtmek gerekiyor.
        // Örnek olarak bunun gibi;  builder.Property(ic => ic.CustomerId).HasColumnName("CustomerId").IsRequired();
        // builder.HasOne(ic => ic.Customer)
        // .WithOne(c => c.IndividualCustomers)
        // .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);

        /*
        builder.Property(m => m.Id).HasColumnName("Id").IsRequired();
        builder.Property(m => m.Name).HasColumnName("Name");
        builder.Property(m => m.Year).HasColumnName("Year");
        builder.Property(m => m.DailyPrice).HasColumnName("DailyPrice");
        builder.Property(m => m.BrandId).HasColumnName("BrandId");
        builder.Property(m => m.FuelId).HasColumnName("FuelId");
        builder.Property(m => m.TransmissionId).HasColumnName("TransmissionId");
        builder.Property(m => m.Brand).HasColumnName("Brand");  // TODO: Burada veritabanı ile ilgili bir sorun oluşuyor. Brand ile alakalı.
        builder.Property(m => m.Fuel).HasColumnName("Fuel");
        builder.Property(m => m.Transmission).HasColumnName("Transmission");
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
        */
    }
}
