namespace Data.Configurations.Application
{
    public class PalestranteConfiguration : IEntityTypeConfiguration<Palestrante>
    {
        public void Configure(EntityTypeBuilder<Palestrante> builder)
        {
            builder.ToTable("palestrante", "dbo");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).ValueGeneratedOnAdd().HasColumnName("nome");
            builder.Property(x => x.Especialidade).ValueGeneratedOnAdd().HasColumnName("especialidade");

            builder.HasOne(x => x.Evento).WithMany(x => x.Palestrantes).HasForeignKey(x => x.Id);
        }
    }
}