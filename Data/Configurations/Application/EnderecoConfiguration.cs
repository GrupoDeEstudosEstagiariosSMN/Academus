namespace Data.Configurations.Application
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_endereco");

            builder.Property(x => x.Cep).HasColumnName("cep");
            builder.Property(x => x.Bairro).HasColumnName("bairro");
            builder.Property(x => x.Logradouro).HasColumnName("logradouro");
            builder.Property(x => x.Numero).HasColumnName("numero");
            builder.Property(x => x.Complemento).HasColumnName("complemento");
        }
    }
}