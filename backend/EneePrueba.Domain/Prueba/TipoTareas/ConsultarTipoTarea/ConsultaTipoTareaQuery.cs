using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;

namespace EneePrueba.Domain.Prueba.TipoTareas.ConsultarTipoTarea;

public class ConsultaTipoTareaQuery : IQuery<ConsultaParametrosDTO>
{
    public string Description { get; } = "Consulta de un registro de tipo";
    public string Nombre { get; set; }
}
