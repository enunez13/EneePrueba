using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;

namespace EneePrueba.Domain.Prueba.Tareas.ConsultaPaginado;

public class ConsultaTareaPaginadoQuery : IQuery<IPaginated<ConsultaTareaDTO>>, IPaginatedParams
{
    public string Description => "Consulta todas tarea";
    public int? PageSize { get; set; }
    public int? Page { get; set; }
}
