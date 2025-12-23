using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("persona_contrato")]
    public class PersonaContrato : AuditableEntity
    {
        [Column("fk_persona")]
        public int? FkPersona { get; set; }

        [Column("fk_contrato")]
        public int? FkContrato { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("fecharegistro")]
        public DateTime? Fecharegistro { get; set; }

        [Column("fecharetiro")]
        public DateTime? Fecharetiro { get; set; }

        [Column("valido")]
        public string? Valido { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("fk_usuarioinsert")]
        public int? FkUsuarioinsert { get; set; }

        [Column("fk_usuariodelete")]
        public int? FkUsuariodelete { get; set; }

    }
}
