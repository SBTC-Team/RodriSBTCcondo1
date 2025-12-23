using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("servicio_contrato")]
    public class ServicioContrato : AuditableEntity
    {
        [Key]
        [Column("pk_servicio_contrato")]
        public int PkServicioContrato { get; set; }

        [Column("costo")]
        public decimal? Costo { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("fk_contrato")]
        public int? FkContrato { get; set; }

        [Column("fk_serviciopago")]
        public int? FkServiciopago { get; set; }

    }
}
