using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("detalleasiento")]
    public class Detalleasiento : AuditableEntity
    {
        [Key]
        [Column("pk_detalleasiento")]
        public int PkDetalleasiento { get; set; }

        [Column("fk_cuenta")]
        public int? FkCuenta { get; set; }

        [Column("fk_asiento")]
        public int? FkAsiento { get; set; }

        [Column("concepto")]
        public string? Concepto { get; set; }

        [Column("debe")]
        public decimal? Debe { get; set; }

        [Column("haber")]
        public decimal? Haber { get; set; }

        [Column("glosa")]
        public string? Glosa { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
