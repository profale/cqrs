using EventosDomain.Entities;
using EventosDomain.Interfaces.IRepositories.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain.Services.Commands
{
    public class CommandHandler : IEventoCommandRepository
    {
        private readonly IEventoCommandRepository _eventoCommandRepository;

        public CommandHandler(IEventoCommandRepository eventoCommandRepository)
        {
            _eventoCommandRepository = eventoCommandRepository;
        }

        public void AddEvento(Evento evento)
        {
            _eventoCommandRepository.AddEvento(evento);
        }
    }
}
