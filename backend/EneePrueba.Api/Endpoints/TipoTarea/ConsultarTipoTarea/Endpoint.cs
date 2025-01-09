using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Prueba;
using EneePrueba.Domain.Prueba.TipoTareas.ConsultarTipoTarea;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.TipoTarea.ConsultarTipoTarea;

public static class Endpoint
{
    public static void ConsultarPorNombre(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/{nombre}",
                async ([FromRoute] string nombre, IQueryDispatcher dispatcher) =>
                {
                    Domain.Prueba.ConsultaParametrosDTO result = await dispatcher.Execute(
                        new ConsultaTipoTareaQuery() { Nombre = nombre }
                    );
                    return result;
                }
            )
            .Produces<Enee.Core.Domain.IPaginated<ConsultaParametrosDTO>>()
            .WithSummary("Obtiene Tipo Tarea")
            .WithOpenApi();
    }
}
