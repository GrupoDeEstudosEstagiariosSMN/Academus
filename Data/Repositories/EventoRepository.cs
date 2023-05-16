namespace Data.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EventoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Evento> BuscarEvento(int id)
        {
            return await _dbContext.Eventos
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Evento>> BuscarEventos(string nome)
        {
            var query = _dbContext.Eventos
                .Include(x => x.Palestrante)
                .Where(x => x.IdPalestrante == x.Palestrante.Id)
                .AsQueryable();

            if (!string.IsNullOrEmpty(nome))
                return await query.Where(x => x.Nome == nome).ToListAsync();
            else return await query.ToListAsync();
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

        public async Task<IEnumerable<Evento>> BuscarEventosAsyncNovo()
        {
            var eventos = await _dbContext.Eventos
                // .Include(x => x.Palestrante)
                .Select(x => new Evento
                {
                    Id = x.Id,
                    IdPalestrante = x.IdPalestrante,
                    Nome = x.Nome,
                    Descricao = x.Descricao,
                    Localizacao = x.Localizacao,
                    PublicoAlvo = x.PublicoAlvo,
                    ValorIngresso = x.ValorIngresso,
                    Custo = x.Custo,
                    Palestrante = new Palestrante
                    {
                        Id = x.Palestrante.Id,
                        Nome = x.Palestrante.Nome,
                        Especialidade = x.Palestrante.Especialidade
                    }
                })
                .ToListAsync();
            return eventos;
        }
    }
}
