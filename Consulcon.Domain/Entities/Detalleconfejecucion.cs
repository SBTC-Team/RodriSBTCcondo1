using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("detalleconfejecucion")]
    public class Detalleconfejecucion : AuditableEntity
    {
        [Column("fk_confejecuciontitulo")]
        public int? FkConfejecuciontitulo { get; set; }

        [Column("fk_confejecucion")]
        public int? FkConfejecucion { get; set; }

        [Key]
        [Column("pk_cuenta")]
        public int PkCuenta { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("nivel1")]
        public int? Nivel1 { get; set; }

        [Column("descripcionejecucion")]
        public string? Descripcionejecucion { get; set; }

        [Column("tipo")]
        public int? Tipo { get; set; }

    }
}
