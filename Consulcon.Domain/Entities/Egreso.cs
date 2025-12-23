using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("egreso")]
    public class Egreso : AuditableEntity
    {
        [Key]
        [Column("pk_egreso")]
        public int PkEgreso { get; set; }

        [Column("numerorecibo")]
        public int? Numerorecibo { get; set; }

        [Column("concepto")]
        public string? Concepto { get; set; }

        [Column("glosa")]
        public string? Glosa { get; set; }

        [Column("monto")]
        public decimal? Monto { get; set; }

        [Column("fechacreacion")]
        public DateTime? Fechacreacion { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("fk_usuario")]
        public int? FkUsuario { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("fk_usuariobaja")]
        public int? FkUsuariobaja { get; set; }

        [Column("motivobaja")]
        public string? Motivobaja { get; set; }

        [Column("fechabaja")]
        public DateTime? Fechabaja { get; set; }

        [Column("cuentadebe")]
        public int? Cuentadebe { get; set; }

        [Column("cuentahaber")]
        public int? Cuentahaber { get; set; }

        [Column("fk_formpago")]
        public int? FkFormpago { get; set; }

        [Column("numerotrans")]
        public string? Numerotrans { get; set; }

        [Column("fk_proveedor")]
        public int? FkProveedor { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

        [Column("fk_autorizacion")]
        public int? FkAutorizacion { get; set; }

        [Column("fk_banco")]
        public int? FkBanco { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

        [Column("nota")]
        public string? Nota { get; set; }

        [Column("fechacobro")]
        public DateTime? Fechacobro { get; set; }

        [Column("fechaconfirmado")]
        public DateTime? Fechaconfirmado { get; set; }

        [Column("cobrado")]
        public string? Cobrado { get; set; }

    }
}
