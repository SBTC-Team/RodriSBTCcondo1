using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("banco")]
    public class Banco : AuditableEntity
    {
        [Key]
        [Column("pk_banco")]
        public int PkBanco { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("fk_cuenta")]
        public int? FkCuenta { get; set; }

        [Column("numero")]
        public string? Numero { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("cuentabanco")]
        public string? Cuentabanco { get; set; }

    }
}
