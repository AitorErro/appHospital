using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Cama : Recurso
    {
        public String estado { get; set; }
        public Char posicion { get; set; }
        public String habitacion { get; set; }
    }
}