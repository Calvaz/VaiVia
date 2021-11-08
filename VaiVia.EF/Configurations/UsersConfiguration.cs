using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ViaVai.Core.Entities;

namespace VaiVia.EF
{
    internal class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.Username)
                .IsRequired()
                .HasMaxLength(10);
            builder.HasIndex(n => n.Username).IsUnique();
        }
    }
}