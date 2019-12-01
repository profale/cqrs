using EventosDomain.Entities;
using EventosDomain.Interfaces.IRepositories.Commands;
using EventosInfra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosInfra.Repositories.EF
{
    public class EventoCommandRepository : IEventoCommandRepository
    {
        private EventoContext _context;

        public EventoCommandRepository(EventoContext context)
        {
            _context = context;
        }

        public void AddEvento(Evento evento)
        {
            _context.Add(evento);
        }
    }
}
