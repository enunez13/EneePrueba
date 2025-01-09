using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.Domain;

namespace EneePrueba.Domain.Prueba
{
    public class ConsultaParametrosDTO
    {
        public string Nombre { get; set; }
    }

    public class ParametrosPaginadoDTO : IPaginated<ConsultaParametrosDTO>
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public int FirstRowOnPage { get; set; }
        public int LastRowOnPage { get; set; }
        public IList<ConsultaParametrosDTO> Data { get; set; }
    }
}
