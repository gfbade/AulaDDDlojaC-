using Loja.Infra.Data.Context;
using Loja.Domain.Entities;
using Loja.Domain.Interfaces.Repository;

namespace Loja.Infra.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(LojaContext context)
            : base(context)
        {
        }    
    }
}
