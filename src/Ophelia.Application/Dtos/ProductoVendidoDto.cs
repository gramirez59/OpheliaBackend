using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Dtos
{
    public class ProductoVendidoDto
    {
        public string Nombre { get; set; }
        public int CantidadVendida { get; set; }
        public long TotalVendido { get; set; }
    }
}
