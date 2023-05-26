namespace Data.Configurations.Application
{
    public class PalestraPalestranteConfiguration : IEntityTypeConfiguration<PalestraPalestrante>
    {
        public void Configure(EntityTypeBuilder<PalestraPalestrante> builder)
        {
            builder.ToTable("palestra_palestrante", "dbo");

            builder.Property(x => x.IdPalestrante).HasColumnName("id_palestrante");
            builder.Property(x => x.IdPalestra).HasColumnName("id_palestra");

        }
    }
}