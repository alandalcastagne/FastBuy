using FastBuy.Dominio.Entidade;
using FastBuy.Dominio.ObjetoValor;
using FastBuy.Repositorio.Config;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Repositorio.Contexto
{
    public  class FBContexto : DbContext
    {
        public DbSet<Usuario>  Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public FBContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de Pagamento Boleto"
                },               
                  new FormaPagamento()
                  {
                      Id = 2,
                      Nome = "Cartão de Crédito",
                      Descricao = "Forma de Pagamento Cartão de Crédito"
                  },
                   new FormaPagamento()
                   {
                       Id = 3,
                       Nome = "Depósito",
                       Descricao = "Forma de Pagamento Depósito"
                   }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
