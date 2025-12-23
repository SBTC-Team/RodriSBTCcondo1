using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("ttcuota")]
    public class Ttcuota : AuditableEntity
    {
        [Key]
        [Column("pk_cuota")]
        public int PkCuota { get; set; }

        [Column("cuota")]
        public decimal? Cuota { get; set; }

        [Column("fk_deuda")]
        public int? FkDeuda { get; set; }

    }
}
