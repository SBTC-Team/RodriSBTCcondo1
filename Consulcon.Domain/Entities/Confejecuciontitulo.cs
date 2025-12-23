using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("confejecuciontitulo")]
    public class Confejecuciontitulo : AuditableEntity
    {
        [Key]
        [Column("pk_confejecuciontitulo")]
        public int PkConfejecuciontitulo { get; set; }

        [Column("fk_confejecucion")]
        public int? FkConfejecucion { get; set; }

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
