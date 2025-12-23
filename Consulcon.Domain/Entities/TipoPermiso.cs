using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("tipo_permiso")]
    public class TipoPermiso : AuditableEntity
    {
        [Column("fk_tipousuario")]
        public int? FkTipousuario { get; set; }

        [Column("fk_permiso")]
        public int? FkPermiso { get; set; }

    }
}
