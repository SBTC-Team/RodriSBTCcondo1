using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("telefono")]
    public class Telefono : AuditableEntity
    {
        [Key]
        [Column("pk_telefono")]
        public int PkTelefono { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("numero")]
        public string? Numero { get; set; }

        [Column("estado")]
        public string? Estado { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

    }
}
