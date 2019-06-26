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
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pc => pc.Id);

            builder
                .Property(pc => pc.Data)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");


            builder
                .Property(pc => pc.UsuarioId)
                .IsRequired()
                .HasColumnType("int");

            builder
                .Property(pc => pc.DataEntregaPedido)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnType("varchar");

            builder
                .Property(pc => pc.CEP)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnType("varchar");

            builder
               .Property(pc => pc.Estado)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("varchar");

            builder
               .Property(pc => pc.Cidade)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("varchar");

            builder
               .Property(pc => pc.EnderecoCompleto)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("varchar");

            builder
               .Property(pc => pc.FormaPagamentoId)
               .IsRequired()
               .HasColumnType("int");

            builder
               .Property(pc => pc.FormaPagamento)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("varchar");

            builder
                .HasOne(pc => pc.Usuario);
            
        }
    }
}
