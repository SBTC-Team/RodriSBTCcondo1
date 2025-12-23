using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("configuracionevento")]
    public class Configuracionevento : AuditableEntity
    {
        [Column("id")]
        public int? Id { get; set; }

        [Column("PrecioChurrasquera")]
        public decimal? Preciochurrasquera { get; set; }

        [Column("PrecioSalon")]
        public decimal? Preciosalon { get; set; }

        [Column("PrecioSalonChurrasquera")]
        public decimal? Preciosalonchurrasquera { get; set; }

        [Column("MontoGarantia")]
        public decimal? Montogarantia { get; set; }

        [Column("NumeroCuenta")]
        public decimal? Numerocuenta { get; set; }

        [Column("Banco")]
        public string? Banco { get; set; }

    }
}
