namespace Data.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EventoRepository(ApplicationDbContext dbContext, IEventoRepository eventoRepository)
        {
            _dbContext = dbContext;
        }

        public async Task CadastrarEvento(Evento evento)
        {
            await _dbContext.Eventos.AddAsync(evento);
        }
    }
}