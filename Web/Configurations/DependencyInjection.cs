using Core.Helpers;

namespace Web.Configurations
{
  public static class DependencyInjection
  {
    public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
      services.AddSingleton(appSettings);

      services.AddControllersWithViews();

      services.AddScoped<Notification>();

      services.AddScoped<ApplicationDbContext>();

      services.AddScoped<IUsuarioRepository, UsuarioRepository>();
      services.AddScoped<IEventoRepository, EventoRepository>();
      services.AddScoped<Notification>();
    }
  }
}
