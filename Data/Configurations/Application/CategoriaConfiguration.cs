namespace Data.Configurations.Application
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.ToTable("categoria", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_categoria");

            builder.Property(x => x.Nome).HasColumnName("nome");
        }
    }
}