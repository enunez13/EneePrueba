using Carter;
using EneePrueba.Api.Endpoints.Parametro.CrearTipoTarea;
using EneePrueba.Api.Endpoints.Tarea.ConsultaPaginado;
using EneePrueba.Api.Endpoints.Tarea.CrearTarea;
using EneePrueba.Api.Endpoints.Tarea.EditarTarea;
using EneePrueba.Api.Endpoints.TipoTarea.ConsultaPaginado;
using EneePrueba.Api.Endpoints.TipoTarea.ConsultarTipoTarea;
using EneePrueba.Api.Endpoints.TipoTarea.EditarTipoTarea;
using EneePrueba.Api.Endpoints.TipoTarea.EliminarTipoTarea;

namespace EneePrueba.Api.Endpoints.Parametro;

public class Endpoints : CarterModule
{
    public Endpoints()
        : base("/api/v1/tipoTarea")
    {
        WithTags("Tipo Tarea");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearTipo();
        app.EditarTipo();
        app.EliminarTipo();
        app.ConsultarPorNombre();
        app.ConsultarTipoPaginados();
    }
}
