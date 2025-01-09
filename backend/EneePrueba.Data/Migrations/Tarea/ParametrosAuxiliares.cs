using System;
using Enee.Core.Migrations.Utlis;
using Enee.IoC.Architecture;
using FluentMigrator;
using Microsoft.Extensions.Options;

namespace EneePrueba.Data.Migrations.Tarea;

[Migration(202501081021)]
public class ParametrosAuxiliares(IOptions<DbSettings> dbSetting) : Migration
{
    public override void Up()
    {
        var schema = dbSetting.Value.SchemaTables;
        Create
            .Table("TipoTarea")
            .InSchema(schema)
            .WithColumn("Id")
            .AsGuid()
            .NotNullable()
            .WithColumn("Nombre")
            .AsString()
            .NotNullable()
            .WithAuditableFields();
        Create
            .Table("EstadoTarea")
            .InSchema(schema)
            .WithColumn("Id")
            .AsGuid()
            .NotNullable()
            .WithColumn("Nombre")
            .AsString()
            .NotNullable()
            .WithAuditableFields();
        Create
            .Table("PrioridadTarea")
            .InSchema(schema)
            .WithColumn("Id")
            .AsGuid()
            .NotNullable()
            .WithColumn("Nombre")
            .AsString()
            .NotNullable()
            .WithAuditableFields();
        Create.WithPrimaryKey("TipoTarea").OnTable("TipoTarea").WithSchema(schema).Column("Id");
        Create.WithPrimaryKey("EstadoTarea").OnTable("EstadoTarea").WithSchema(schema).Column("Id");
        Create
            .WithPrimaryKey("PrioridadTarea")
            .OnTable("PrioridadTarea")
            .WithSchema(schema)
            .Column("Id");
        Create
            .WithForeignKey("Tarea", 1)
            .FromTable("Tarea")
            .InSchema(schema)
            .ForeignColumn("TipoTareaId")
            .ToTable("TipoTarea")
            .InSchema(schema)
            .PrimaryColumn("Id");
        Create
            .WithForeignKey("Tarea", 2)
            .FromTable("Tarea")
            .InSchema(schema)
            .ForeignColumn("EstadoId")
            .ToTable("EstadoTarea")
            .InSchema(schema)
            .PrimaryColumn("Id");
        Create
            .WithForeignKey("Tarea", 3)
            .FromTable("Tarea")
            .InSchema(schema)
            .ForeignColumn("PrioridadId")
            .ToTable("PrioridadTarea")
            .InSchema(schema)
            .PrimaryColumn("Id");
    }

    public override void Down() { }
}
