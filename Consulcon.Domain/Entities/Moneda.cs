using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("moneda")]
    public class Moneda : AuditableEntity
    {
        [Key]
        [Column("pk_moneda")]
        public int PkMoneda { get; set; }

        [Column("moneda")]
        public string? MonedaProperty { get; set; }

        [Column("tipocambio")]
        public decimal? Tipocambio { get; set; }

        [Column("abreviado")]
        public string? Abreviado { get; set; }

    }
}
