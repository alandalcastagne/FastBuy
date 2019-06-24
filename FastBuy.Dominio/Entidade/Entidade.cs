using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Dominio.Entidade
{
    public abstract class entidade
    {
        public List<string> _mensagemDeValidacao { get; set; }

        private List<string> GetMensagemDeValidacao
        {
            get { return _mensagemDeValidacao ?? (_mensagemDeValidacao = new List<string>()); }
        }

        public abstract void Validate();
        protected void LimparMensagem()
        {
            _mensagemDeValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            _mensagemDeValidacao.Add(mensagem);
        }


        protected bool ehValido
        {
            get { return GetMensagemDeValidacao.Any(); }
        }
    }
}
