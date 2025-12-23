using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("deuda")]
    public class Deuda : AuditableEntity
    {
        [Key]
        [Column("pk_deuda")]
        public int PkDeuda { get; set; }

        [Column("fk_servicio")]
        public int? FkServicio { get; set; }

        [Column("fk_contrato")]
        public int? FkContrato { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("fechadeuda")]
        public DateTime? Fechadeuda { get; set; }

        [Column("monto")]
        public decimal? Monto { get; set; }

        [Column("pagado")]
        public string? Pagado { get; set; }

        [Column("estado")]
        public string? Estado { get; set; }

        [Column("fechabaja")]
        public DateTime? Fechabaja { get; set; }

        [Column("motivobaja")]
        public string? Motivobaja { get; set; }

        [Column("fk_usuarioalta")]
        public int? FkUsuarioalta { get; set; }

        [Column("fk_usuariobaja")]
        public int? FkUsuariobaja { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
