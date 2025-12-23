using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("contrato")]
    public class Contrato : AuditableEntity
    {
        [Key]
        [Column("pk_contrato")]
        public int PkContrato { get; set; }

        [Column("fk_propiedad")]
        public int? FkPropiedad { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("fechaini")]
        public DateTime? Fechaini { get; set; }

        [Column("fechafin")]
        public DateTime? Fechafin { get; set; }

        [Column("fechaingreso")]
        public DateTime? Fechaingreso { get; set; }

        [Column("expensa")]
        public decimal? Expensa { get; set; }

        [Column("valido")]
        public string? Valido { get; set; }

        [Column("fechabaja")]
        public DateTime? Fechabaja { get; set; }

        [Column("motivo")]
        public string? Motivo { get; set; }

        [Column("fk_usuarioinsert")]
        public int? FkUsuarioinsert { get; set; }

        [Column("fk_usuariodelete")]
        public int? FkUsuariodelete { get; set; }

        [Column("diaini")]
        public int? Diaini { get; set; }

        [Column("diafin")]
        public int? Diafin { get; set; }

        [Column("fk_condominio")]
        public int? FkCondominio { get; set; }

    }
}
