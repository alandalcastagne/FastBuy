using FastBuy.Dominio.Contratos;
using FastBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBuy.Repositorio.Repositorio
{
    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {
        protected readonly FBContexto Fbcontexto;

        public BaseRepositorio(FBContexto fBContexto)
        {
            Fbcontexto = fBContexto;
        }

         public void Adicionar(Tentity entity)
        {
            Fbcontexto.Set<Tentity>().Add(entity);
            Fbcontexto.SaveChanges();
        }

        public void Atualizar(Tentity entity)
        {
            Fbcontexto.Set<Tentity>().Update(entity);
            Fbcontexto.SaveChanges();
        }

         public Tentity ObterPorId(int id)
        {
            return Fbcontexto.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> ObterTodos()
        {
            return Fbcontexto.Set<Tentity>().ToList();
        }

        public void Remover(Tentity entity)
        {
            Fbcontexto.Remove(entity);
            Fbcontexto.SaveChanges();
        }

        public void Dispose()
        {
            Fbcontexto.Dispose();
        }

     
    }

       

       
    
}
