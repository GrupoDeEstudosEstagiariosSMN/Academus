using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Configurations.Application
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("fornecedor");

            builder.HasKey(x => x.Id).HasName("pk_fornecedor");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Representante).HasColumnName("representante");
            builder.Property(x => x.Produto).HasColumnName("produto");
        }
    }
}
