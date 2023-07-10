using LittleTeti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleTeti.Data.Mappings;
public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Address");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.PostalCode)
            .IsRequired()
            .HasColumnName("PostaCode")
            .HasColumnType("INT")
            .HasMaxLength(8);

        builder.Property(x => x.Complement)
            .IsRequired(false)
            .HasColumnName("Complement")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.Number)
            .IsRequired()
            .HasColumnName("Number")
            .HasColumnType("INT")
            .HasMaxLength(5);

        builder.Property(x => x.Street)
            .IsRequired()
            .HasColumnName("Location")
            .HasColumnType("VARCHAR")
            .HasMaxLength(120);

        builder.Property(x => x.Neighborhood)
            .IsRequired()
            .HasColumnName("Neighborhood")
            .HasColumnType("VARCHAR")
            .HasMaxLength(120);

        builder.Property(x => x.City)
            .IsRequired()
            .HasColumnName("City")
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);

        builder.Property(x => x.State)
            .IsRequired()
            .HasColumnName("State")
            .HasColumnType("VARCHAR")
            .HasMaxLength(2);

    }
}