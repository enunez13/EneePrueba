using Enee.Core.Common;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.Projections;

public class PrioridadTarea : IEntity<Guid>
{
    public PrioridadTarea(Guid id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public Guid Id { get; set; }
    public string Nombre { get; set; }
}
