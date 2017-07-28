using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Medico : Persona
    {
        public String especialidad { get; set; }
        public String tipo { get; set; }
        public Boolean especialista { get; set; }
    }
}