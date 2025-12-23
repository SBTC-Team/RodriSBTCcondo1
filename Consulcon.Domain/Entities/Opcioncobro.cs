using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("opcioncobro")]
    public class Opcioncobro : AuditableEntity
    {
        [Key]
        [Column("pk_opcioncobro")]
        public int PkOpcioncobro { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

    }
}
