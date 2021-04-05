using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Entidades
{
    [Table("ArticulosVenta", Schema = "ophelia")]
    public class ArticuloVenta : Entity<Int64>, IAudited
    {
        [Required, Column(name: "IdVenta")]
        public long IdVenta { get; set; }

        [ForeignKey("IdVenta")]
        public Venta VentaAsociada { get; set; }

        [Required, Column(name: "IdProducto")]
        public long IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public Producto ProductoAsociado { get; set; }
        //****** A partir de aca columnas de Auditoria

        /// <summary>
        /// Fecha de creación del Cliente
        /// </summary>
        [Required, Column(name: "CreationTime")]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Identificador del usuario que creó el Cliente
        /// </summary>
        [Column(name: "CreatorUserId")]
        public long? CreatorUserId { get; set; }

        /// <summary>
        /// Fecha de la ultima modificación realizada al Cliente
        /// </summary>
        [Column(name: "LastModificationTime")]
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Identificador del usuario que realizó la ultima modificación al Cliente
        /// </summary>
        [Column(name: "LastModifierUserId")]
        public long? LastModifierUserId { get; set; }
    }
}
