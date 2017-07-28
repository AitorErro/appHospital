using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Cita
    {
        public DateTime fecha { get; set; }
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
        public Prestacion prestacion { get; set; }
    }
}