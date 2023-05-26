namespace Data.Configurations.Application
{
    public class PalestranteConfiguration : IEntityTypeConfiguration<Palestrante>
    {
        public void Configure(EntityTypeBuilder<Palestrante> builder)
        {
            builder.ToTable("palestrante", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_palestrante");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");

            // builder.HasMany(x => x.Eventos).WithOne(x => x.Palestrante).HasForeignKey(x => x.IdPalestrante);
        }
    }
}
