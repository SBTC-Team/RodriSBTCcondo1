using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("permiso")]
    public class Permiso : AuditableEntity
    {
        [Key]
        [Column("pk_permiso")]
        public int PkPermiso { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

    }
}
