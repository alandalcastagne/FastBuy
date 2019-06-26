using FastBuy.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Repositorio.Config
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder
               .HasMany(u => u.Pedidos)
               .WithOne(p => p.Usuario);


        }
    }
}
