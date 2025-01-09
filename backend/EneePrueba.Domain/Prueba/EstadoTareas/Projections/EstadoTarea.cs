using Enee.Core.Common;

namespace EneePrueba.Domain.Prueba.EstadoTareas.Projections;

public class EstadoTarea : IEntity<Guid>
{
    public EstadoTarea(Guid id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public Guid Id { get; set; }
    public string Nombre { get; set; }
}
