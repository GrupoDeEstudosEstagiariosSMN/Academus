namespace Data.Configurations.Application
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("curso", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_curso");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.CargaHoraria).HasColumnName("carga_horaria");
            builder.Property(x => x.Professor).HasColumnName("professor");
            builder.Property(x => x.Trilha).HasColumnName("trilha");

        }
    }
}
