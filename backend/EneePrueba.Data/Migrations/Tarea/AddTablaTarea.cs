using Enee.Core.Migrations.Utlis;
using Enee.IoC.Architecture;
using FluentMigrator;
using Microsoft.Extensions.Options;

namespace EneePrueba.Data.Migrations.Tarea;

[Migration(202501080921)]
public class AddTablaTarea(IOptions<DbSettings> dbSetting) : Migration
{
    public override void Up()
    {
        var schema = dbSetting.Value.SchemaTables;
        Create
            .Table("Tarea")
            .InSchema(schema)
            .WithColumn("Id")
            .AsGuid()
            .NotNullable()
            .WithColumn("Nombre")
            .AsString()
            .NotNullable()
            .WithColumnDescription("Nombre Asignado a la tarea.) ")
            .WithColumn("Descripcion")
            .AsString(12)
            .NotNullable()
            .WithColumnDescription("Descripción asignada a la tarea.")
            .WithColumn("FechaInicio")
            .AsCustom("date")
            .NotNullable()
            .WithColumn("FechaFin")
            .AsCustom("date")
            .NotNullable()
            .WithColumn("TipoTareaId")
            .AsGuid()
            .NotNullable()
            .WithColumn("EstadoId")
            .AsGuid()
            .NotNullable()
            .WithColumn("PrioridadId")
            .AsGuid()
            .NotNullable()
            .WithAuditableFields();
        Create.WithPrimaryKey("tarea").OnTable("tarea").WithSchema(schema).Column("Id");
    }

    public override void Down() { }
}
