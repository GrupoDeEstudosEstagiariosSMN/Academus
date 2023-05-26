namespace Data.Configurations.Application
{
    public class EventoOrganizadorConfiguration : IEntityTypeConfiguration<EventoOrganizador>
    {
        public void Configure(EntityTypeBuilder<EventoOrganizador> builder)
        {
            builder.ToTable("evento_organizador", "dbo");

            builder.HasOne(x => x.Evento).WithMany(x => x.EventosOrganizadores).HasForeignKey("id");
            builder.HasOne(x => x.Organizador).WithMany(x => x.EventosOrganizadores).HasForeignKey("id");
        }
    }
}