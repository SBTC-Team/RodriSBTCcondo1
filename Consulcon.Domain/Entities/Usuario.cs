using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("usuario")]
    public class Usuario : AuditableEntity
    {
        [Key]
        [Column("pk_usuario")]
        public int PkUsuario { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("usuario")]
        public string? UsuarioProperty { get; set; }

        [Column("contrasena")]
        public string? Contrasena { get; set; }

        [Column("habilitado")]
        public string? Habilitado { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("nombrepersona")]
        public string? Nombrepersona { get; set; }

        [Column("fk_tipousuario")]
        public int? FkTipousuario { get; set; }

    }
}
