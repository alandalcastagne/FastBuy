namespace FastBuy.Dominio.Entidade
{
    public class Produto : entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagem();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("O nome do produto precisa ser preenchido!");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("A descrição do produto precisa ser preenchido!");
            }

            if (Preco < 0)
            {
                AdicionarCritica("O Preço do produto não pode ser negativo!");
            }
        }
    }
}
