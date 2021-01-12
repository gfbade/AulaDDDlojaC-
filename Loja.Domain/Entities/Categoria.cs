
using System.Collections.Generic;

namespace Loja.Domain.Entities
{
    public class Categoria
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}
