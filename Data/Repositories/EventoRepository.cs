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
    public async Task<Evento> BuscarEvento(int id)
    {
      return await _dbContext.Eventos
           .Where(x => x.Id == id).FirstOrDefaultAsync();
    }
    public async Task CadastrarEvento(Evento evento)
    {
      await _dbContext.Eventos.AddAsync(evento);
      await _dbContext.SaveChangesAsync();
    }
    public async Task EditarEvento(Evento evento)
    {
      _dbContext.Eventos.Update(evento);
      await _dbContext.SaveChangesAsync();
    }

    public async Task ExcluirEvento(int id)
    {
      var evento = await _dbContext.Eventos.FirstOrDefaultAsync(x => x.Id == id);
      if (evento != null)
      {
        _dbContext.Eventos.Remove(evento);
        await _dbContext.SaveChangesAsync();
      }
    }
  }
}