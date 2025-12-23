using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("serviciopago")]
    public class Serviciopago : AuditableEntity
    {
        [Key]
        [Column("pk_serviciopago")]
        public int PkServiciopago { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("costo")]
        public decimal? Costo { get; set; }

        [Column("estado")]
        public string? Estado { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
