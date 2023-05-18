namespace Data.Configurations.Application
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("aluno", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_aluno");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Turma).HasColumnName("turma");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Matricula).HasColumnName("matricula");
        }
    }
}
