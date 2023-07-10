using LittleTeti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LittleTeti.Data.Mappings;

public class SolicitationMap : IEntityTypeConfiguration<Solicitation>
{
    public void Configure(EntityTypeBuilder<Solicitation> builder)
    {
        builder.ToTable("Solicitatio");

        builder.HasKey(x => x.Id);
    }
}