using Loja.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Domain.Models
{
    public class CategoriaModel
    {
        public CategoriaModel()
        {

        }
        public CategoriaModel(long id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
        public long Id { get; set; }
        public string Descricao { get; set; }
       
    }
}
