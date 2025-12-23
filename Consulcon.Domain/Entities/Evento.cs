using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Consulcon.Domain.Common;

namespace Consulcon.Domain.Entities
{
    [Table("evento")]
    public class Evento : AuditableEntity
    {
        [Key]
        [Column("pk_evento")]
        public int PkEvento { get; set; }

        [Column("fecha")]
        public DateTime? Fecha { get; set; }

        [Column("anio")]
        public int? Anio { get; set; }

        [Column("mes")]
        public int? Mes { get; set; }

        [Column("dia")]
        public int? Dia { get; set; }

        [Column("horainicio")]
        public string? Horainicio { get; set; }

        [Column("horafin")]
        public string? Horafin { get; set; }

        [Column("fk_contrato")]
        public int? FkContrato { get; set; }

        [Column("fk_propietario")]
        public int? FkPropietario { get; set; }

        [Column("fk_persona")]
        public int? FkPersona { get; set; }

        [Column("disponible")]
        public string? Disponible { get; set; }

        [Column("numero")]
        public int? Numero { get; set; }

        [Column("colorChurrasquera")]
        public string? Colorchurrasquera { get; set; }

        [Column("checkChurrasquera")]
        public string? Checkchurrasquera { get; set; }

        [Column("checkSalon")]
        public string? Checksalon { get; set; }

        [Column("MotivoEvento")]
        public string? Motivoevento { get; set; }

        [Column("NumeroInvitados")]
        public string? Numeroinvitados { get; set; }

        [Column("CelularContacto")]
        public string? Celularcontacto { get; set; }

        [Column("Amenizado")]
        public string? Amenizado { get; set; }

        [Column("PropietarioInquilino")]
        public string? Propietarioinquilino { get; set; }

    }
}
