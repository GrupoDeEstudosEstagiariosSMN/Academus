namespace Data.Configurations.Application
{
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("projeto");

            builder.HasKey(x => x.Id).HasName("pk_projeto");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Titulo).HasColumnName("titulo");
            builder.Property(x => x.Descricao).HasColumnName("descricao");
            builder.Property(x => x.Autor).HasColumnName("autor");
            builder.Property(x => x.Disciplina).HasColumnName("disciplina");
            builder.Property(x => x.PrazoInicial).HasColumnName("prazo_inicial");
            builder.Property(x => x.PrazoFinal).HasColumnName("prazo_final");
            builder.Property(x => x.Nota).HasColumnName("nota");
        }
    }
}
