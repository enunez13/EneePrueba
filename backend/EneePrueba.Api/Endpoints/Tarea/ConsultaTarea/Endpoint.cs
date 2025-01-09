using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.Tarea.ConsultaTarea;

public static class Endpoint
{
    public static void ConsultarPorNombre(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/{nombre}",
                async ([FromRoute] string nombre, IQueryDispatcher dispatcher) =>
                {
                    ConsultaTareaDTO result = await dispatcher.Execute(
                        new ConsultaTareaQuery() { Nombre = nombre }
                    );
                    return result;
                }
            )
            .Produces<Enee.Core.Domain.IPaginated<ConsultaTareaDTO>>()
            .WithSummary("Obtiene tarea")
            .WithOpenApi();
    }
}
