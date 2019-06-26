using FastBuy.Dominio.ObjetoValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Repositorio.Config
{
    class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {

            builder.HasKey(f => f.Id);

            builder
               .Property(f => f.Nome)
               .IsRequired()
               .HasMaxLength(50);

            builder
               .Property(f => f.Descricao)
               .IsRequired()
               .HasMaxLength(400);           
        }
    }
}
