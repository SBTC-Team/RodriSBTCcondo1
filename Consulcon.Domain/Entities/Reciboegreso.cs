using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("reciboegreso")]
    public class Reciboegreso : AuditableEntity
    {
        [Key]
        [Column("pk_reciboegreso")]
        public int PkReciboegreso { get; set; }

        [Column("fk_condominio")]
        public int? FkCondominio { get; set; }

    }
}
