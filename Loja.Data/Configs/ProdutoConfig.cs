using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Infra.Data.Configs
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable(nameof(Produto));

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Descricao)
                .IsRequired();

            builder.HasOne(prop => prop.Categoria)
                .WithMany(prop => prop.Produtos)
                .HasForeignKey(prop => prop.IdCategoria);
        }
    }
}
