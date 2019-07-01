using FastBuy.Dominio.Contratos;
using FastBuy.Dominio.Entidade;
using FastBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Repositorio.Repositorio
{
    public class PedidoRepositorio: BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(FBContexto fBContexto) : base(fBContexto)
        {

        }
    }
}
