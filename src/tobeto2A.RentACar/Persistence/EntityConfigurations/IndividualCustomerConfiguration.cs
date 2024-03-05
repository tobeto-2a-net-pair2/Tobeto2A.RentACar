using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.HasKey(ic => ic.Id);
        builder.ToTable("IndividualCustomers");

        // CustomerId alanýný belirledik ve bir foreign key olarak ayarladýk
        builder.Property(ic => ic.CustomerId).HasColumnName("CustomerId").IsRequired();
        builder.HasOne(ic => ic.Customer)
               .WithOne(c => c.IndividualCustomers)
               .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);

        // Diðer propertyler
        builder.Property(ic => ic.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(ic => ic.LastName).HasColumnName("LastName").IsRequired();
        builder.Property(ic => ic.NationalIdentity).HasColumnName("NationalIdentity").IsRequired();

        /*
        builder.Property(ic => ic.Id).HasColumnName("Id").IsRequired();
        builder.Property(ic => ic.FirstName).HasColumnName("FirstName");
        builder.Property(ic => ic.LastName).HasColumnName("LastName");
        builder.Property(ic => ic.NationalIdentity).HasColumnName("NationalIdentity");
        builder.Property(ic => ic.CustomerId).HasColumnName("CustomerId");
        builder.Property(ic => ic.Customer).HasColumnName("Customer");
        builder.Property(ic => ic.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ic => ic.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ic => ic.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(ic => !ic.DeletedDate.HasValue);
        */
    }
}