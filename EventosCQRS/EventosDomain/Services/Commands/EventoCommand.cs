using EventosDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain.Services.Commands
{
    public abstract class EventoCommand : Command
    {
        public Evento Evento { get; set; }

        public EventoCommand(Evento evento)
        {
            Evento = evento;
        }
    }
}
