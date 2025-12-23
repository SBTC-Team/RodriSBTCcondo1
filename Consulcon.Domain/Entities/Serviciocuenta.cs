using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("serviciocuenta")]
    public class Serviciocuenta : AuditableEntity
    {
        [Key]
        [Column("pk_serviciocuenta")]
        public int PkServiciocuenta { get; set; }

        [Column("fk_servicio")]
        public int? FkServicio { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Key]
        [Column("pk_cuenta")]
        public int PkCuenta { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

    }
}
