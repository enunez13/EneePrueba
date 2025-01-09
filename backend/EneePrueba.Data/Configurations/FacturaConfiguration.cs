using EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EneePrueba.Data.Configurations;

public class FacturaConfiguration : IEntityTypeConfiguration<Facturas>
{
    /// <summary>
    /// Método de configuración
    /// </summary>
    /// <param name="builder"></param>

    public void Configure(EntityTypeBuilder<Facturas> builder)
    {
        builder.ToTable("factura", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));
        builder.HasKey(x => x.Id);
    }
}
