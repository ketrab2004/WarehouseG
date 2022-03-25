using Warehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Warehouse.Infrastructure.Configurations
{
    public class CustomerContactConfiguration : IEntityTypeConfiguration<CustomerContactEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerContactEntity> builder)
        {
            builder.ToTable("CustomerContact");

            // primary key
            builder.HasKey(columns => columns.Id);
            builder.Property(columns => columns.Id)
                    .HasColumnName("Id");

            // foreign key Customer
            builder.Property(columns => columns.CustomerId)
                    .HasColumnName("CustomerId")
                    .IsRequired(true);

            // foreign key Contact
            builder.Property(columns => columns.ContactId)
                    .HasColumnName("ContactId")
                    .IsRequired(true);

            builder.HasOne(columns => columns.Contact)
                    .WithMany(other => other.CustomerContactList)
                    .HasForeignKey(columns => columns.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContact_Contact");

            // time info
            builder.Property(columns => columns.DateCreated)
                    .IsRequired(true);

            builder.Property(columns => columns.DateModified)
                    .IsRequired(true);

            builder.Property(columns => columns.Timestamp)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("rowversion")
                    .IsRequired(true);
        }
    }
}
