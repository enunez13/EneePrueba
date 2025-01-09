using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EneePrueba.Domain.Prueba.Tareas.Projections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EneePrueba.Data.Configurations;

public class TareaConfiguration : IEntityTypeConfiguration<Tarea>
{
    public void Configure(EntityTypeBuilder<Tarea> builder)
    {
        builder.ToTable("tarea", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));
        builder.HasKey(x => x.Id);
    }
}
