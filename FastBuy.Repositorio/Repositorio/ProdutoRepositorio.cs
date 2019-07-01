using FastBuy.Dominio.Entidade;
using FastBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastBuy.Repositorio.Contexto;

namespace FastBuy.Repositorio.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(FBContexto fBContexto) : base(fBContexto)
        {
        }
    }
}
