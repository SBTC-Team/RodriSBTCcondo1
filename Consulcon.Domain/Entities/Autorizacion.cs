using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("autorizacion")]
    public class Autorizacion : AuditableEntity
    {
        [Key]
        [Column("pk_autorizacion")]
        public int PkAutorizacion { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
