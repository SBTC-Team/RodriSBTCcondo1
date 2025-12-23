using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("condominio")]
    public class Condominio : AuditableEntity
    {
        [Key]
        [Column("pk_condominio")]
        public int PkCondominio { get; set; }

        [Column("codigo")]
        public string? Codigo { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("administrador")]
        public int? Administrador { get; set; }

        [Column("m2")]
        public decimal? M2 { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("vh")]
        public string? Vh { get; set; }

        [Column("diacobro")]
        public string? Diacobro { get; set; }

    }
}
