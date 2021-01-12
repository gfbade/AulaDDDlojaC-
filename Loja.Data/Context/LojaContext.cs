using Loja.Infra.Data.Configs;
using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Loja.Infra.Data.Context
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options)
            : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>(new ProdutoConfig().Configure);
            modelBuilder.Entity<Categoria>(new CategoriaConfig().Configure);        
         
        }
    }
}
