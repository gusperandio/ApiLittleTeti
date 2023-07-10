using LittleTeti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleTeti.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        builder.Property(x => x.Name)
        .IsRequired()
        .HasColumnName("Name")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

        builder.Property(x => x.Email)
        .IsRequired()
        .HasColumnName("Email")
        .HasColumnType("VARCHAR")
        .HasMaxLength(160);

        builder.Property(x => x.PasswordHash)
        .IsRequired()
        .HasColumnName("PasswordHash");

        builder.Property(e => e.CreatedAt)
            .ValueGeneratedOnAdd()
            .HasDefaultValueSql("GETDATE()");
        builder.Property(e => e.UpdatedAt)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValueSql("GETDATE()");

        builder
               .HasMany(x => x.Roles)
               .WithMany(x => x.Users)
               .UsingEntity<Dictionary<string, object>>(
                   "UserRole",
                   role => role
                       .HasOne<Role>()
                       .WithMany()
                       .HasForeignKey("RoleId")
                       .HasConstraintName("FK_UserRole_RoleId")
                       .OnDelete(DeleteBehavior.Cascade),
                   user => user
                       .HasOne<User>()
                       .WithMany()
                       .HasForeignKey("UserId")
                       .HasConstraintName("FK_UserRole_UserId")
                       .OnDelete(DeleteBehavior.Cascade));

        builder.HasOne(u => u.Address)
            .WithOne()
            .HasForeignKey<User>(u => u.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Solicitations)
            .WithOne(s => s.User)
            .HasForeignKey(s => s.User.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}