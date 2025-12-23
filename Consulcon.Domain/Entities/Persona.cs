using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("persona")]
    public class Persona : AuditableEntity
    {
        [Key]
        [Column("pk_persona")]
        public int PkPersona { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("ci")]
        public string? Ci { get; set; }


        [Column("fechanac")]
        public DateTime? Fechanac { get; set; }

        [Column("estadocivil")]
        public string? Estadocivil { get; set; }

        [Column("direccion")]
        public string? Direccion { get; set; }

        [Column("relacion")]
        public string? Relacion { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

        [Column("telefono")]
        public string? Telefono { get; set; }

        [Column("celular")]
        public string? Celular { get; set; }

        [Column("email")]
        public string? Email { get; set; }

    }
}
