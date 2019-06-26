using System.Collections.Generic;

namespace FastBuy.Dominio.Entidade
{
    public class Usuario : entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagem();

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("O Email precisa ser preenchido!");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("A Senha precisa ser preenchida!");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("O nome precisa ser preenchido!");
            }

            if (string.IsNullOrEmpty(SobreNome))
            {
                AdicionarCritica("O Sobre nome precisa ser preenchido!");
            }
        }
    }
}
