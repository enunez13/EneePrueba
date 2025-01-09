using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;

namespace EneePrueba.Domain.Prueba.EstadoTareas.ConsultaPaginado;

public class ConsultaEstadoTareaPaginadoQuery
    : IQuery<IPaginated<ConsultaParametrosDTO>>,
        IPaginatedParams
{
    public string Description => "Consulta todos tipos tarea";
    public int? PageSize { get; set; }
    public int? Page { get; set; }
}
