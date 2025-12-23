using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("tabla_servicio")]
    public class TablaServicio : AuditableEntity
    {
        [Key]
        [Column("pk_contrato")]
        public int PkContrato { get; set; }

        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("propietario")]
        public string? Propietario { get; set; }

        [Column("nservicio1")]
        public string? Nservicio1 { get; set; }

        [Column("nservicio2")]
        public string? Nservicio2 { get; set; }

        [Column("nservicio3")]
        public string? Nservicio3 { get; set; }

        [Column("nservicio4")]
        public string? Nservicio4 { get; set; }

        [Column("nservicio5")]
        public string? Nservicio5 { get; set; }

        [Column("servicio1")]
        public decimal? Servicio1 { get; set; }

        [Column("servicio2")]
        public decimal? Servicio2 { get; set; }

        [Column("servicio3")]
        public decimal? Servicio3 { get; set; }

        [Column("servicio4")]
        public decimal? Servicio4 { get; set; }

        [Column("servicio5")]
        public decimal? Servicio5 { get; set; }

        [Column("total")]
        public decimal? Total { get; set; }

    }
}
