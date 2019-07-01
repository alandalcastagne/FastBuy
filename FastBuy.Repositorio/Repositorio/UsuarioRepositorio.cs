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
    class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(FBContexto fBContexto) : base(fBContexto)
        {
        }

    }
}
