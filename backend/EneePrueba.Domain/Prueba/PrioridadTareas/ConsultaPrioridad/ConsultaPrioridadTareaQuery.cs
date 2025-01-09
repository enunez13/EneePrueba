using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.ConsultaPrioridad;

public class ConsultaPrioridadTareaQuery : IQuery<ConsultaParametrosDTO>
{
    public string Description { get; } = "Consulta de un registro de tipo";
    public string Nombre { get; set; }
}
