using Enee.Core.Common;

namespace EneePrueba.Domain.Prueba.Tareas.Projections
{
    public class Tarea : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public Guid TipoTareaId { get; set; }
        public Guid EstadoId { get; set; }
        public Guid PrioridadId { get; set; }
    }
}
