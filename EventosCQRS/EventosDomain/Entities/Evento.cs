using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain.Entities
{
    public class Evento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public string Local { get; set; }

    }
}
