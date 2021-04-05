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
    [Table("Productos", Schema = "ophelia")]
    public class Producto : Entity<Int64>, IAudited
    {
        /// <summary>
        /// Nombre del Producto
        /// </summary>
        [Required, Column(name: "Nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Marca del Producto
        /// </summary>
        [Required, Column(name: "Marca")]
        public string Marca { get; set; }

        /// <summary>
        /// Cantidad del Producto en el Inventario
        /// </summary>
        [Required, Column(name: "CantidadInventario")]
        public int CantidadInventario { get; set; }

        /// <summary>
        /// Precio Unitario del Producto
        /// </summary>
        [Required, Column(name: "PrecioUnitario")]
        public long PrecioUnitario { get; set; }

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
