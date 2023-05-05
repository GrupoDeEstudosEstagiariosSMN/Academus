namespace Data.Configurations.Application
{
    public class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("evento", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_evento");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Descricao).HasColumnName("descricao");
            builder.Property(x => x.Localizacao).HasColumnName("localizacao");
            builder.Property(x => x.Palestrante).HasColumnName("palestrante");
            builder.Property(x => x.PublicoAlvo).HasColumnName("publico_alvo");
            builder.Property(x => x.ValorIngresso).HasColumnName("valor_ingresso");
            builder.Property(x => x.Custo).HasColumnName("custo");
        }
    }
}