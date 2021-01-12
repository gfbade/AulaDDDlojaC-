using Loja.Domain.Entities;
using Loja.Domain.Interfaces.Repository;
using Loja.Domain.Interfaces.Service;
using Loja.Domain.Models;
using Loja.Infra.Shared.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Service.Service
{
    public class CategoriaService : ICategoriaService
    {      
        private readonly ICategoriaRepository CategoriaRepository;
        private readonly IProdutoRepository ProdutoRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            CategoriaRepository = categoriaRepository;
            ProdutoRepository = produtoRepository;
        }

        public virtual CategoriaModel Add(CategoriaModel cliente)
        {
            return CategoriaRepository.Add(cliente.ConvertToUserEntity()).ConvertToUser();
        }

        public virtual CategoriaModel GetById(long id)
        {
            return CategoriaRepository.GetById(id).ConvertToUser();
        }

        public virtual void Update(CategoriaModel cliente)
        {
            CategoriaRepository.Update(cliente.ConvertToUserEntity());
        }

        public virtual void Remove(long id)
        {
            var produtos = ProdutoRepository.GetAll().Where(c=> c.IdCategoria == id);
            if(produtos.Any())
            {
                throw new Exception("Essa categoria possui produtos associados");
            }
            CategoriaRepository.Remove(id);
        }

        public virtual IEnumerable<CategoriaModel> GetAll()
        {
            return CategoriaRepository.GetAll().ConvertToUsers();
        }    
    }
}
