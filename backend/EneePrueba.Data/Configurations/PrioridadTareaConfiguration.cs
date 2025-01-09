using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;
using EneePrueba.Domain.Prueba.PrioridadTareas.Projections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EneePrueba.Data.Configurations;

public class PrioridadTareaConfiguration : IEntityTypeConfiguration<PrioridadTarea>
{
    public void Configure(EntityTypeBuilder<PrioridadTarea> builder)
    {
        builder.ToTable("prioridad_tarea", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));
        builder.HasKey(x => x.Id);
    }
}
