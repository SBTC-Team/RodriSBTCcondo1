using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("tipousuario")]
    public class Tipousuario : AuditableEntity
    {
        [Key]
        [Column("pk_tipousuario")]
        public int PkTipousuario { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

    }
}
