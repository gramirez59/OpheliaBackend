using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Dtos
{
    public class ProductoDto
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int CantidadInventario { get; set; }
        public long PrecioUnitario { get; set; }
    }
}
