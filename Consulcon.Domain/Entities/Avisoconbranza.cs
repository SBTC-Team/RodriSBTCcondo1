using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("avisoconbranza")]
    public class Avisoconbranza : AuditableEntity
    {
        [Key]
        [Column("pk_avisoconbranza")]
        public int PkAvisoconbranza { get; set; }

        [Key]
        [Column("pk_servicio1")]
        public int PkServicio1 { get; set; }

        [Key]
        [Column("pk_servicio2")]
        public int PkServicio2 { get; set; }

        [Key]
        [Column("pk_servicio3")]
        public int PkServicio3 { get; set; }

        [Key]
        [Column("pk_servicio4")]
        public int PkServicio4 { get; set; }

        [Key]
        [Column("pk_servicio5")]
        public int PkServicio5 { get; set; }

        [Column("servicio1")]
        public string? Servicio1 { get; set; }

        [Column("servicio2")]
        public string? Servicio2 { get; set; }

        [Column("servicio3")]
        public string? Servicio3 { get; set; }

        [Column("servicio4")]
        public string? Servicio4 { get; set; }

        [Column("servicio5")]
        public string? Servicio5 { get; set; }

        [Column("mes1")]
        public int? Mes1 { get; set; }

        [Column("mes2")]
        public int? Mes2 { get; set; }

        [Column("mes3")]
        public int? Mes3 { get; set; }

        [Column("mes4")]
        public int? Mes4 { get; set; }

        [Column("mes5")]
        public int? Mes5 { get; set; }

        [Column("anio1")]
        public int? Anio1 { get; set; }

        [Column("anio2")]
        public int? Anio2 { get; set; }

        [Column("anio3")]
        public int? Anio3 { get; set; }

        [Column("anio4")]
        public int? Anio4 { get; set; }

        [Column("anio5")]
        public int? Anio5 { get; set; }

    }
}
