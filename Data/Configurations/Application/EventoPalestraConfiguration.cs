namespace Data.Configurations.Application
{
    public class EventoPalestraConfiguration : IEntityTypeConfiguration<EventoPalestra>
    {
        public void Configure(EntityTypeBuilder<EventoPalestra> builder)
        {
            builder.ToTable("evento_palestra", "dbo");

            builder.HasKey(x => new { x.IdEvento, x.IdPalestra }).HasName("pk_evento_palestra");

            builder.Property(x => x.IdEvento).HasColumnName("id_evento");
            builder.Property(x => x.IdPalestra).HasColumnName("id_palestra");

            builder.HasOne(x => x.Evento).WithMany(x => x.EventosPalestras).HasForeignKey(x => x.IdEvento);
            builder.HasOne(x => x.Palestra).WithMany(x => x.EventosPalestras).HasForeignKey(x => x.IdPalestra);
        }
    }
}