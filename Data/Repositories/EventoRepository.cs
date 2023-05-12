namespace Data.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EventoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Evento>> BuscarEventos(int id, string nome)
        {
            var query = _dbContext.Eventos
                .Include(x => x.Palestrantes)
                .AsQueryable();

            if (id != default)
                query.Where(x => x.Id == id);
            if (!string.IsNullOrEmpty(nome))
                query.Where(x => x.Nome == nome);

            return await query
                .ToListAsync();
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
