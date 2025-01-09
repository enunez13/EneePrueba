using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using EneePrueba.Domain.Prueba;
using EneePrueba.Domain.Prueba.Tareas.ConsultaPaginado;
using EneePrueba.Domain.Prueba.Tareas.ConsultarTarea;

namespace EneePrueba.Api.Endpoints.Tarea.ConsultaPaginado;

public static class Endpoint
{
    public static void ConsultarTareaPaginados(this IEndpointRouteBuilder app)
    {
        app.MapGet(
                "/",
                async (
                    [AsParameters] ConsultaTareaPaginadoQuery query,
                    IQueryDispatcher dispatcher
                ) =>
                {
                    IPaginated<ConsultaTareaDTO> result = await dispatcher.Execute(query);
                    return result;
                }
            )
            .Produces<IPaginated<ConsultaTareaDTO>>()
            .WithSummary("Obtiene listado de  Tarea paginados")
            .WithDescription("Listar  Tarea  pagina.")
            .WithOpenApi();
    }
}
