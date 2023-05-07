namespace Data.Repositories
{
  public class EventoRepository : IEventoRepository
  {
    private readonly ApplicationDbContext _dbContext;
    public EventoRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    public async Task<IEnumerable<Evento>> BuscarEventos()
    {
      return await _dbContext.Eventos.ToListAsync();
    }

    public async Task CadastrarEvento(Evento evento)
    {
      await _dbContext.Eventos.AddAsync(evento);
      await _dbContext.SaveChangesAsync();
    }
  }
}