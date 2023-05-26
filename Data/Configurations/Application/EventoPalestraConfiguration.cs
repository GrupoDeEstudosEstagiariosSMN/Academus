namespace Data.Configurations.Application
{
    public class EventoPalestraConfiguration : IEntityTypeConfiguration<EventoPalestra>
    {
        public void Configure(EntityTypeBuilder<EventoPalestra> builder)
        {
            builder.ToTable("evento_palestra", "dbo");

            builder.HasOne(x => x.Evento).WithMany(x => x.EventosOrganizadores).HasForeignKey("id");
        }
    }
}