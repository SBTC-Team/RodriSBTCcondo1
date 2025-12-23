using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("confejecucion")]
    public class Confejecucion : AuditableEntity
    {
        [Key]
        [Column("pk_confejecucion")]
        public int PkConfejecucion { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("tipo")]
        public string? Tipo { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
