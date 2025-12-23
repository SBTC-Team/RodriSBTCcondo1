using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("recibopersonal")]
    public class Recibopersonal : AuditableEntity
    {
        [Key]
        [Column("pk_recibopersonal")]
        public int PkRecibopersonal { get; set; }

        [Column("fk_contrato")]
        public int? FkContrato { get; set; }

    }
}
