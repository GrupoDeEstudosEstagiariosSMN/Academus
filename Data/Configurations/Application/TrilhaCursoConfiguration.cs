namespace Data.Configurations.Application
{
    public class TrilhaCursoConfiguration : IEntityTypeConfiguration<TrilhaCurso>
    {
        public void Configure(EntityTypeBuilder<TrilhaCurso> builder)
        {
            builder.ToTable("trilha_curso", "dbo");

            builder.HasKey(x => new { x.IdTrilha, x.IdCurso }).HasName("pk_trilha_curso");

            builder.Property(x => x.IdCurso).HasColumnName("id_curso");
            builder.Property(x => x.IdTrilha).HasColumnName("id_trilha");

            builder.HasOne(x => x.Curso).WithMany(x => x.TrilhaCursos).HasForeignKey(x => x.IdCurso);
            builder.HasOne(x => x.Trilha).WithMany(x => x.TrilhaCursos).HasForeignKey(x => x.IdTrilha);
        }
    }
}