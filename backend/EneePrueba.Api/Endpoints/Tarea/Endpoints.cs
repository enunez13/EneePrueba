using Carter;
using EneePrueba.Api.Endpoints.Parametro.CrearTipoTarea;
using EneePrueba.Api.Endpoints.Tarea.ConsultaPaginado;
using EneePrueba.Api.Endpoints.Tarea.ConsultaTarea;
using EneePrueba.Api.Endpoints.Tarea.CrearTarea;
using EneePrueba.Api.Endpoints.Tarea.EditarTarea;
using EneePrueba.Api.Endpoints.Tarea.EliminarTarea;
using EneePrueba.Api.Endpoints.TipoTarea.ConsultaPaginado;

namespace EneePrueba.Api.Endpoints.Tarea;

public class Endpoints : CarterModule
{
    public Endpoints()
        : base("/api/v1/tarea")
    {
        WithTags("Tarea");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearTarea();
        app.EditarTarea();
        app.EliminarTarea();
        app.ConsultarPorNombre();
        app.ConsultarTareaPaginados();
    }
}
