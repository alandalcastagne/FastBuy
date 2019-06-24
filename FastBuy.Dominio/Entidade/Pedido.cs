using FastBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;

namespace FastBuy.Dominio.Entidade
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataEntregaPedido { get; set; }

        public int CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
