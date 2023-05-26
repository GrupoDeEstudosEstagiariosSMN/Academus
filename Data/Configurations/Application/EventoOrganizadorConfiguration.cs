namespace Data.Configurations.Application
{
    public class EventoOrganizadorConfiguration : IEntityTypeConfiguration<EventoOrganizador>
    {
        public void Configure(EntityTypeBuilder<EventoOrganizador> builder)
        {
            builder.ToTable("evento_organizador", "dbo");

            builder.HasKey(x => new { x.IdEvento, x.IdOrganizador }).HasName("pk_evento");

            builder.Property(x => x.IdEvento).HasColumnName("id_evento");
            builder.Property(x => x.IdOrganizador).HasColumnName("id_organizador");
            builder.Property(x => x.Responsavel).HasColumnName("responsavel");

            builder.HasOne(x => x.Evento).WithMany(x => x.EventosOrganizadores).HasForeignKey(x => x.IdEvento);
            builder.HasOne(x => x.Organizador).WithMany(x => x.EventosOrganizadores).HasForeignKey(x => x.IdOrganizador);
        }
    }
}