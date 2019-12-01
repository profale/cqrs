using System;
using System.Collections.Generic;
using System.Text;

namespace EventosDomain
{
    public abstract class QueueMessage : Message
    {
        public abstract string QueueName { get; }
    }
}
