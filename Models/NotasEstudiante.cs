using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NOTASDEESTUDIANTE.Models
{
    public partial class NotasEstudiante
    {
        [DisplayName("ID de la Nota")]
        public int IdnotasEstudiantes { get; set; }

        [DisplayName("Carné")]
        [Required]
        public string? Carnet { get; set; }

        [DisplayName("Apellido(s)")]
        [Required]
        public string? Apellido { get; set; }

        [DisplayName("Nombre(s)")]
        [Required]
        public string? Nombre { get; set; }

        [DisplayName("Ier Parcial")]
        [Required]
        [Range(0,35)]
        public short? NotaIp { get; set; }

        [DisplayName("IIdo Parcial")]
        [Range(0, 35)]
        public short? NotaIip { get; set; }

        [DisplayName("Sistematicos")]
        [Range(0, 30)]
        [Required]
        public short? NotaSist { get; set; }

        [Range(0, 35)]
        [DisplayName("Proyecto Final")]
        public short? NotaProy { get; set; }

        
        [DisplayName("Nota Final")]
        public short? NotaFinal { get; set; }
    }
}
