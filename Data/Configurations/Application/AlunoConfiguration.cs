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
            builder.Property(x => x.Apelido).HasColumnName("apelido");
            builder.Property(x => x.Matricula).HasColumnName("descricao");
            builder.Property(x => x.Cpf).HasColumnName("cpf");
            builder.Property(x => x.Celular).HasColumnName("celular");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.IdTrilha).HasColumnName("id_trilha");

            builder.HasOne(x => x.Trilha).WithMany(x => x.Alunos).HasForeignKey(x => x.IdTrilha);

        }
    }
}