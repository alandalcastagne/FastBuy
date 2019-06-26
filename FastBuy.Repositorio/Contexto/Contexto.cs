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
    public  class Contexto : DbContext
    {
        public DbSet<Usuario>  Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public Contexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
