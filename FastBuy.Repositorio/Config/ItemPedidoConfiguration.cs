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
    class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.ProdutoId)
                .IsRequired()
                .HasColumnType("int");

            builder
                .Property(i => i.Quantidade)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
