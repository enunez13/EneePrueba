using Carter;
using EneePrueba.Api.Modules.Almacen.Features.CrearAlmacen;
using EneePrueba.Api.Modules.Almacen.Features.RecuperarAlmacenes;

namespace EneePrueba.Api.Modules.Almacen;

public class Endpoints : CarterModule
{
    public Endpoints()
        : base("/api/v1/almacen")
    {
        this.WithTags("Almacen");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearAlmancen();
        app.RecuperarAlmacenes();
    }
}
