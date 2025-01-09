using Carter;
using EneePrueba.Api.Modules.Factura.Features.ConsultarFacturas;
using EneePrueba.Api.Modules.Factura.Features.CrearFacturas;
using EneePrueba.Api.Modules.Factura.Features.EditarFacturas;
using EneePrueba.Api.Modules.Factura.Features.EliminarFactura;
using EneePrueba.Api.Modules.Factura.Features.EliminarItemFactura;
using EneePrueba.Api.Modules.Factura.Features.RecuperarFactura;

namespace EneePrueba.Api.Modules.Factura;

public class Endpoints : CarterModule
{
    public Endpoints()
        : base("/api/v1/facturas")
    {
        this.WithTags("Facturas");
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearFactura();
        app.EditarFactura();
        app.RecuperarFactura();
        app.ConsultarFacturas();
        app.EliminarFactura();
        app.EliminarItemFactura();
    }
}
