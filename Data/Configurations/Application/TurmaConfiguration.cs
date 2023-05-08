namespace Data.Configurations.Application
{
    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("turma", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_turma");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.QuantidadeAlunos).HasColumnName("quantidade_alunos");
            builder.Property(x => x.Sala).HasColumnName("sala");
            builder.Property(x => x.Turno).HasColumnName("turno");

        }
    }
}
