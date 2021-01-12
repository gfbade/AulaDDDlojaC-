

namespace Loja.Domain.Entities
{
    public class Produto
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        
        public long IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
