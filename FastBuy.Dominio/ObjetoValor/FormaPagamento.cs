using FastBuy.Dominio.Entidade;
using FastBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Dominio.ObjetoValor
{
    public class FormaPagamento : entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamento.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamento.CartaoDeCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamento.Deposito; }
        }

        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamento.NaoDefinido; }
        }

        public override void Validate()
        {
            LimparMensagem();
            if (Id < 0 && Id > 3 )
            {
                AdicionarCritica("O código do método de pagamento é inválido!");
            }
        }
    }


}
