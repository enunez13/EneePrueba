using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EneePrueba.Domain.Prueba.Tareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EneePrueba.Data.Configurations;

public class TipoTareaConfiguration : IEntityTypeConfiguration<TipoTarea>
{
    public void Configure(EntityTypeBuilder<TipoTarea> builder)
    {
        builder.ToTable("tipo_tarea", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));
        builder.HasKey(x => x.Id);
    }
}
