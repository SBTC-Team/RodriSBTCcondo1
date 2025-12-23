using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("cuota")]
    public class Cuota : AuditableEntity
    {
        [Key]
        [Column("pk_cuota")]
        public int PkCuota { get; set; }

        [Column("fk_deuda")]
        public int? FkDeuda { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("monto")]
        public decimal? Monto { get; set; }

        [Column("formapago")]
        public string? Formapago { get; set; }

        [Column("banco")]
        public string? Banco { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

        [Column("tipocambio")]
        public decimal? Tipocambio { get; set; }

        [Column("fechabaja")]
        public DateTime? Fechabaja { get; set; }

        [Column("motivo")]
        public string? Motivo { get; set; }

        [Column("fk_usuarioalta")]
        public int? FkUsuarioalta { get; set; }

        [Column("fk_usuariobaja")]
        public int? FkUsuariobaja { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("recibogeneral")]
        public int? Recibogeneral { get; set; }

        [Column("recibopersonal")]
        public int? Recibopersonal { get; set; }

        [Column("fk_banco")]
        public int? FkBanco { get; set; }

        [Column("fk_formapago")]
        public int? FkFormapago { get; set; }

        [Column("fechadeposito")]
        public DateTime? Fechadeposito { get; set; }

        [Column("cuentadebe")]
        public int? Cuentadebe { get; set; }

        [Column("cuentahaber")]
        public int? Cuentahaber { get; set; }

        [Column("fk_moneda")]
        public int? FkMoneda { get; set; }

        [Column("fk_opcion_pago")]
        public int? FkOpcionPago { get; set; }

    }
}
