using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;

namespace EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;

public class ConsultaTareaQuery : IQuery<ConsultaTareaDTO>
{
    public string Description { get; } = "Consulta de un registro de tarea";
    public string Nombre { get; set; }
}
