using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea7_App.Models
{
    public partial class Vacunados
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Provincia { get; set; }
        public string SignoZodiacal { get; set; }
        public string MarcaVacuna { get; set; }
        public string FechaPdosis { get; set; }
        public string FechaSdosis { get; set; }
    }
}
