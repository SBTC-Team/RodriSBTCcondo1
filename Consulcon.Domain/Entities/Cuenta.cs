using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("cuenta")]
    public class Cuenta : AuditableEntity
    {
        [Key]
        [Column("pk_cuenta")]
        public int PkCuenta { get; set; }

        [Column("numero")]
        public int? Numero { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("nivel")]
        public int? Nivel { get; set; }

        [Column("fk_cuenta")]
        public int? FkCuenta { get; set; }

        [Column("nivel1")]
        public int? Nivel1 { get; set; }

        [Column("nivel2")]
        public int? Nivel2 { get; set; }

        [Column("nivel3")]
        public int? Nivel3 { get; set; }

        [Column("nivel4")]
        public int? Nivel4 { get; set; }

        [Column("nivel5")]
        public int? Nivel5 { get; set; }

    }
}
