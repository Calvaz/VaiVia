using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ViaVai.Core.Entities;

namespace VaiVia.EF
{
    internal class NationsConfiguration : IEntityTypeConfiguration<Nations>
    {
        public void Configure(EntityTypeBuilder<Nations> builder)
        {
            builder.HasKey(n => n.Id);
            
            builder.Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(20);
            builder.HasIndex(n => n.Name).IsUnique();
        }
    }
}