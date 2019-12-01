using EventosDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain.Interfaces.IRepositories.Commands
{
    public interface IEventoCommandRepository
    {
        void AddEvento(Evento evento);
    }
}
