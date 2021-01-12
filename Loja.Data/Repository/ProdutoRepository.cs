using Loja.Infra.Data.Context;
using Loja.Domain.Entities;
using Loja.Domain.Interfaces.Repository;

namespace Loja.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(LojaContext context)
            : base(context)
        {
        }
    }
}
