using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("ttdeuda")]
    public class Ttdeuda : AuditableEntity
    {
        [Key]
        [Column("pk_deuda")]
        public int PkDeuda { get; set; }

        [Column("monto")]
        public decimal? Monto { get; set; }

    }
}
