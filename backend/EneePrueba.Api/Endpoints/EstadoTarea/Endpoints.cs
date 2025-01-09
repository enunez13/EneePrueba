using Carter;
using EneePrueba.Api.Endpoints.EstadoTarea.ConsultaPaginado;
using EneePrueba.Api.Endpoints.EstadoTarea.ConsultarEstado;
using EneePrueba.Api.Endpoints.EstadoTarea.CrearEstadoTarea;
using EneePrueba.Api.Endpoints.EstadoTarea.EditarEstadoTarea;
using EneePrueba.Api.Endpoints.EstadoTarea.EliminarEstadoTarea;
using EneePrueba.Api.Endpoints.Parametro.CrearTipoTarea;
using EneePrueba.Api.Endpoints.PrioridadTarea.CrearPrioridadTarea;
using EneePrueba.Api.Endpoints.TipoTarea.EditarTipoTarea;

namespace EneePrueba.Api.Endpoints.EstadoTarea;

public class Endpoints : CarterModule
{
    public Endpoints()
        : base("/api/v1/estadoTarea")
    {
        WithTags("Estado Tarea");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearEstado();
        app.EditarEstado();
        app.EliminarEstado();
        app.ConsultarPorNombre();
        app.ConsultarEstadoPaginados();
    }
}
