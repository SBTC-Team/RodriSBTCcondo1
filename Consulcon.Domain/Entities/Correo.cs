using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("correo")]
    public class Correo : AuditableEntity
    {
        [Key]
        [Column("pk_correo")]
        public int PkCorreo { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

    }
}
