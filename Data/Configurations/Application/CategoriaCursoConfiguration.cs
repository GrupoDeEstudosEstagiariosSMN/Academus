namespace Data.Configurations.Application
{
    public class CategoriaCursoConfiguration : IEntityTypeConfiguration<CategoriaCurso>
    {
        public void Configure(EntityTypeBuilder<CategoriaCurso> builder)
        {
            builder.ToTable("categoria_curso", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_categoria_curso");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");

        }
    }
}