using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("propiedad")]
    public class Propiedad : AuditableEntity
    {
        [Key]
        [Column("pk_propiedad")]
        public int PkPropiedad { get; set; }

        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("m2")]
        public decimal? M2 { get; set; }

        [Column("expensa")]
        public decimal? Expensa { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

        [Column("fk_manzano")]
        public int? FkManzano { get; set; }

        [Column("fk_condominio")]
        public int? FkCondominio { get; set; }

    }
}
