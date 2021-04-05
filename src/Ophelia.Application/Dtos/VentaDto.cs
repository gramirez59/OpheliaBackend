using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Dtos
{
    public class VentaDto
    {
        public long Id { get; set; }
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public long ValorTotal { get; set; }
        public int CantidadArticulos { get; set; }
    }
}
