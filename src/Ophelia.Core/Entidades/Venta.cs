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
    [Table("Ventas", Schema = "ophelia")]
    public class Venta : Entity<Int64>, IAudited
    {
        [Required, Column(name: "IdCliente")]
        public long IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente ClienteAsociado { get; set; }

        [Required, Column(name: "Fecha")]
        public DateTime? Fecha { get; set; }

        public List<ArticuloVenta> ArticulosAsociados { get; set; }

        [Required, Column(name: "ValorTotal")]
        public long ValorTotal { get; set; }

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
