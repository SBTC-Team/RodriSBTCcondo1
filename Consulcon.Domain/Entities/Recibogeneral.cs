using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("recibogeneral")]
    public class Recibogeneral : AuditableEntity
    {
        [Key]
        [Column("pk_recibogeneral")]
        public int PkRecibogeneral { get; set; }

        [Column("fk_condominio")]
        public int? FkCondominio { get; set; }

    }
}
