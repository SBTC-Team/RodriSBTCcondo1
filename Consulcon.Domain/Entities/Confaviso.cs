using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("confaviso")]
    public class Confaviso : AuditableEntity
    {
        [Key]
        [Column("pk_confaviso")]
        public int PkConfaviso { get; set; }

        [Column("fechaemision")]
        public DateTime? Fechaemision { get; set; }

        [Column("header")]
        public string? Header { get; set; }

        [Column("fechavencimiento")]
        public DateTime? Fechavencimiento { get; set; }

        [Column("condominio")]
        public string? Condominio { get; set; }

        [Column("footer")]
        public string? Footer { get; set; }

    }
}
