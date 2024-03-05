using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(i => i.Id);
        builder.ToTable("Customers");

        // UserId alanýný belirledik ve bir foreign key olarak ayarladýk
        builder.Property(c => c.UserId).HasColumnName("UserId").IsRequired();
        builder.HasOne(c => c.User)
               .WithMany()
               .HasForeignKey(c => c.UserId);

        // IndividualCustomer ile iliþkiyi belirttik
        builder.HasOne(c => c.IndividualCustomers)
               .WithOne(ic => ic.Customer)
               .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);

        // CorporateCustomer ile iliþkiyi belirttik
        builder.HasOne(c => c.CorporateCustomers)
               .WithOne(cc => cc.Customer)
               .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);

        /*
        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.UserId).HasColumnName("UserId");
        builder.Property(c => c.User).HasColumnName("User");
        builder.Property(c => c.IndividualCustomers).HasColumnName("IndividualCustomers");
        builder.Property(c => c.CorporateCustomers).HasColumnName("CorporateCustomers");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        */
    }
}