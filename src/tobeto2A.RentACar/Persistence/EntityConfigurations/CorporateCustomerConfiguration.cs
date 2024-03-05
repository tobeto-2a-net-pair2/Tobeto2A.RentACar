using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
{
    public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
    {
        builder.HasKey(cc => cc.Id);
        builder.ToTable("CorporateCustomers");

        // CustomerId alanýný belirledik ve bir foreign key olarak ayarladýk
        builder.Property(cc => cc.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.HasOne(cc => cc.Customer)
               .WithOne(c => c.CorporateCustomers)
               .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);

        // Diðer propertyler
        builder.Property(cc => cc.CompanyName).HasColumnName("CompanyName").IsRequired();
        builder.Property(cc => cc.TaxNo).HasColumnName("TaxNo").IsRequired();

        /*
        builder.Property(cc => cc.Id).HasColumnName("Id").IsRequired();
        builder.Property(cc => cc.CustomerId).HasColumnName("CustomerId");
        builder.Property(cc => cc.CompanyName).HasColumnName("CompanyName");
        builder.Property(cc => cc.TaxNo).HasColumnName("TaxNo");
        builder.Property(cc => cc.Customer).HasColumnName("Customer");
        builder.Property(cc => cc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(cc => cc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(cc => cc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(cc => !cc.DeletedDate.HasValue);
        */
    }
}