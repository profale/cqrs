using EventosDomain.Entities;
using EventosDomain.Interfaces.IRepositories.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain.Services.Queries
{
    public class EventoQueries
    {
        private readonly IEventoQueriesRepository _eventoQueriesRepository;

        public EventoQueries(IEventoQueriesRepository eventoQueriesRepository)
        {
            _eventoQueriesRepository = eventoQueriesRepository;
        }

        public IEnumerable<Evento> ListarTodos()
        {
            return _eventoQueriesRepository.ListarTodos();
        }

        public Evento Obter(Guid id)
        {
            return _eventoQueriesRepository.Obter(id);
        }
    }
}
