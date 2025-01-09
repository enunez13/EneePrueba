using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Prueba;
using EneePrueba.Domain.Prueba.PrioridadTareas.ConsultaPrioridad;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.PrioridadTarea.ConsultarPrioridadTarea;

public static class Endpoint
{
    public static void ConsultarPorNombre(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/{nombre}",
                async ([FromRoute] string nombre, IQueryDispatcher dispatcher) =>
                {
                    ConsultaParametrosDTO result = await dispatcher.Execute(
                        new ConsultaPrioridadTareaQuery() { Nombre = nombre }
                    );
                    return result;
                }
            )
            .Produces<Enee.Core.Domain.IPaginated<ConsultaParametrosDTO>>()
            .WithSummary("Obtiene prioridad")
            .WithOpenApi();
    }
}
