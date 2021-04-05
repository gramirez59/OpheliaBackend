using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Entidades
{
    public class ProductosVendidos : Entity<int>
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadVendida { get; set; }
        public long TotalVendido { get; set; }
    }
}
