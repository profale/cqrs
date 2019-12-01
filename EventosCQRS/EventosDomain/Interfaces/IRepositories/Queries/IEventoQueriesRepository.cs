using EventosDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain.Interfaces.IRepositories.Queries
{
    public interface IEventoQueriesRepository
    {
        IEnumerable<Evento> ListarTodos();
        Evento Obter(Guid id);
    }
}
