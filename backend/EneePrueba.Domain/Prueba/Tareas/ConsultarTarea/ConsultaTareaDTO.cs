using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.Domain;

namespace EneePrueba.Domain.Prueba.Tareas.ConsultarTarea
{
    public class ConsultaTareaDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public Guid TipoTareaId { get; set; }
        public Guid EstadoId { get; set; }
        public Guid PrioridadId { get; set; }
    }

    public class TareaPaginadoDTO : IPaginated<ConsultaTareaDTO>
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public int FirstRowOnPage { get; set; }
        public int LastRowOnPage { get; set; }
        public IList<ConsultaTareaDTO> Data { get; set; }
    }
}
