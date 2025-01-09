using Enee.Core.Common;

namespace EneePrueba.Domain.Prueba.TipoTareas.Projections;

public class TipoTarea : IEntity<Guid>
{
    public TipoTarea(Guid id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public Guid Id { get; set; }
    public string Nombre { get; set; }
}
