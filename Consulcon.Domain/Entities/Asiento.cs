using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("asiento")]
    public class Asiento : AuditableEntity
    {
        [Key]
        [Column("pk_asiento")]
        public int PkAsiento { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("documento")]
        public string? Documento { get; set; }

        [Column("numerodocumento")]
        public string? Numerodocumento { get; set; }

        [Column("fk_banco")]
        public int? FkBanco { get; set; }

        [Column("cheque")]
        public string? Cheque { get; set; }

        [Column("tc")]
        public decimal? Tc { get; set; }

        [Column("tipoasiento")]
        public string? Tipoasiento { get; set; }

        [Column("fk_cuenta")]
        public int? FkCuenta { get; set; }

        [Column("fk_deuda")]
        public int? FkDeuda { get; set; }

        [Column("glosa")]
        public string? Glosa { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("fechabaja")]
        public DateTime? Fechabaja { get; set; }

        [Column("fechaupdate")]
        public DateTime? Fechaupdate { get; set; }

        [Column("fk_usuariobaja")]
        public int? FkUsuariobaja { get; set; }

        [Column("fk_usuarioupdate")]
        public int? FkUsuarioupdate { get; set; }

        [Column("fk_proceso")]
        public int? FkProceso { get; set; }

        [Column("formulario")]
        public string? Formulario { get; set; }

        [Column("numero")]
        public int? Numero { get; set; }

        [Column("fechacreacion")]
        public DateTime? Fechacreacion { get; set; }

        [Column("fk_usuario")]
        public int? FkUsuario { get; set; }

        [Column("motivobaja")]
        public string? Motivobaja { get; set; }

    }
}
