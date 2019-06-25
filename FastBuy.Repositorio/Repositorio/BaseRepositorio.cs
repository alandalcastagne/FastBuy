using FastBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Repositorio.Repositorio
{
    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {

        public BaseRepositorio()
        {

        }

         public void Adicionar(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Tentity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tentity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Tentity entity)
        {
            throw new NotImplementedException();
        }
    }
}
