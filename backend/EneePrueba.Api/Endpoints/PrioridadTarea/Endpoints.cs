using Carter;
using EneePrueba.Api.Endpoints.EstadoTarea.CrearEstadoTarea;
using EneePrueba.Api.Endpoints.PrioridadTarea.ConsultaPaginado;
using EneePrueba.Api.Endpoints.PrioridadTarea.ConsultarPrioridadTarea;
using EneePrueba.Api.Endpoints.PrioridadTarea.CrearPrioridadTarea;
using EneePrueba.Api.Endpoints.PrioridadTarea.EditarPrioridadTarea;
using EneePrueba.Api.Endpoints.PrioridadTarea.EliminarPrioridadTarea;
using EneePrueba.Api.Endpoints.TipoTarea.ConsultaPaginado;

namespace EneePrueba.Api.Endpoints.PrioridadTarea;

public class Endpoints : CarterModule
{
    public Endpoints()
        : base("/api/v1/prioridadTarea")
    {
        WithTags("Prioridad Tarea");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearPrioridad();
        app.EditarPrioridad();
        app.EliminarPrioridad();
        app.ConsultarPorNombre();
        app.ConsultarPrioridadPaginados();
    }
}
