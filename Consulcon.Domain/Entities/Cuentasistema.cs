using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("cuentasistema")]
    public class Cuentasistema : AuditableEntity
    {
        [Key]
        [Column("pk_cuentasistema")]
        public int PkCuentasistema { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Key]
        [Column("pk_cuenta")]
        public int PkCuenta { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

        [Column("opcion")]
        public string? Opcion { get; set; }

    }
}
