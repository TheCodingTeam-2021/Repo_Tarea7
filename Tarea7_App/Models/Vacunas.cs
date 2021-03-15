using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea7_App.Models
{
    public partial class Vacunas
    {
        public long Id { get; set; }
        public string Marca { get; set; }
        public string Laboratorio { get; set; }
        public int Cantidad { get; set; }
    }
}
