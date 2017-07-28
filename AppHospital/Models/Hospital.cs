using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Hospital
    {
        public String nombre { get; set; }
        public List<Medico> medicos { get; set; }
        public List<Prestacion> prestaciones { get; set; }
        public List<Cama> camas { get; set; }
    }
}