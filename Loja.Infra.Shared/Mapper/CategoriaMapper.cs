using Loja.Domain.Entities;
using Loja.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Infra.Shared.Mapper
{
    public static class CategoriaMapper
    {
        public static Categoria ConvertToUserEntity(this CriarCategoriaModel categoriaModel) =>
               new Categoria() { Descricao = categoriaModel.Descricao, Id = 0 };

        public static CategoriaModel ConvertToUser(this Categoria categoria) =>
          new CategoriaModel(categoria.Id, categoria.Descricao);

        public static Categoria ConvertToUserEntity(this CategoriaModel categoriaModel) =>
        new Categoria() { Descricao = categoriaModel.Descricao, Id = categoriaModel.Id };

        public static IEnumerable<CategoriaModel> ConvertToUsers(this IEnumerable<Categoria> users) =>
          users.Select(s => new CategoriaModel(s.Id, s.Descricao));

    }
}
