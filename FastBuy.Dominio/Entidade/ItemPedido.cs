namespace FastBuy.Dominio.Entidade
{
    public class ItemPedido : entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagem();
            if (Quantidade <= 0)
            {
                AdicionarCritica("Precisa ter pelo menos uma unidade do item!");
            }
        }
    }
}
