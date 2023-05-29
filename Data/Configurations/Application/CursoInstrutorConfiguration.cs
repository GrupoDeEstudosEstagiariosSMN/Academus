namespace Data.Configurations.Application
{
    public class CursoInstrutorConfiguration : IEntityTypeConfiguration<CursoInstrutor>
    {
        public void Configure(EntityTypeBuilder<CursoInstrutor> builder)
        {
            builder.ToTable("curso_instrutor", "dbo");

            builder.HasKey(x => new { x.IdCurso, x.IdInstrutor }).HasName("pk_curso_instrutor");

            builder.Property(x => x.IdInstrutor).HasColumnName("id_instrutor");
            builder.Property(x => x.IdCurso).HasColumnName("id_curso");

            builder.HasOne(x => x.Curso).WithMany(x => x.CursoInstrutores).HasForeignKey(x => x.IdCurso);
            builder.HasOne(x => x.Instrutor).WithMany(x => x.CursoInstrutores).HasForeignKey(x => x.IdInstrutor);
        }
    }
}