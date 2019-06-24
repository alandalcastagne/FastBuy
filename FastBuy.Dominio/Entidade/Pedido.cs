using FastBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FastBuy.Dominio.Entidade
{
    public class Pedido : entidade
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataEntregaPedido { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {

            LimparMensagem();
            if (!ItensPedidos.Any())
            {            
                AdicionarCritica("O Pedido precisa de itens!");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("O CEP Precisa ser preenchido!");
            }
        }
    }
}
