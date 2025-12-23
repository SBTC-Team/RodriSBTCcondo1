using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("empresa")]
    public class Empresa : AuditableEntity
    {
        [Key]
        [Column("pk_empresa")]
        public int PkEmpresa { get; set; }

        [Column("empresa")]
        public string? EmpresaProperty { get; set; }

        [Column("telefono")]
        public string? Telefono { get; set; }

        [Column("direccion")]
        public string? Direccion { get; set; }

        [Column("facebook")]
        public string? Facebook { get; set; }

        [Column("twiter")]
        public string? Twiter { get; set; }

        [Column("habilitado")]
        public string? Habilitado { get; set; }

    }
}
