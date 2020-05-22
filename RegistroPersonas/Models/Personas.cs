using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace RegistroPersonas.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el telefono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la cedula")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la direccion")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir el nacimiento")]
        public DateTime Nacimiento { get; set; }


        public Personas()
        {
            PersonaId = 0;
            Nombre = string.Empty; 
            Telefono = string.Empty; 
            Cedula = string.Empty;
            Direccion = string.Empty; 
            Nacimiento = DateTime.Now;
        }
    }
}
