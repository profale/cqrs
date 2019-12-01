using EventosDomain.Entities;
using EventosDomain.Interfaces.IRepositories.Queries;
using EventosInfra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventosInfra.Repositories.EF
{
    public class EventoQueryRepository : IEventoQueriesRepository
    {
        private EventoContext _context;

        ///TODO: ver com o Gustavo
        public EventoQueryRepository(EventoContext context)
        {
            _context = context;
        }

        public IEnumerable<Evento> ListarTodos()
        {
            return _context.Eventos;
        }

        public Evento Obter(Guid id)
        {
            return _context.Eventos.SingleOrDefault(e => e.Id == id);
        }
    }
}
