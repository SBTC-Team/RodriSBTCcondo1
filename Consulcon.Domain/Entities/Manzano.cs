using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("manzano")]
    public class Manzano : AuditableEntity
    {
        [Key]
        [Column("pk_manzano")]
        public int PkManzano { get; set; }

        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("fk_condominio")]
        public int? FkCondominio { get; set; }

    }
}
