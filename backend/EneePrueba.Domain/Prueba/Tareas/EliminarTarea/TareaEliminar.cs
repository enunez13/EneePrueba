using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.Common;

namespace EneePrueba.Domain.Prueba.Tareas.EliminarTarea;

public class TareaEliminar : DomainEvent<Guid>
{
    public TareaEliminar(Guid aggregateId)
        : base(aggregateId) { }
}
