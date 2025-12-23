using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("proveedor")]
    public class Proveedor : AuditableEntity
    {
        [Key]
        [Column("pk_proveedor")]
        public int PkProveedor { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("nit")]
        public string? Nit { get; set; }

        [Column("telefono")]
        public string? Telefono { get; set; }

        [Column("celular")]
        public string? Celular { get; set; }

        [Column("direccion")]
        public string? Direccion { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("activo")]
        public string? Activo { get; set; }

    }
}
