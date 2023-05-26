namespace Data.Configurations.Application
{
    public class OrganizadorConfiguration : IEntityTypeConfiguration<Organizador>
    {
        public void Configure(EntityTypeBuilder<Organizador> builder)
        {
            builder.ToTable("organizador", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_organizador");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).ValueGeneratedOnAdd().HasColumnName("nome");
            builder.Property(x => x.Cpnj).ValueGeneratedOnAdd().HasColumnName("cnpj");
            builder.Property(x => x.Telefone).ValueGeneratedOnAdd().HasColumnName("telefone");

            builder.HasMany(x => x.EventosOrganizadores).WithOne(x => x.Organizador).HasForeignKey("id");
        }
    }
}