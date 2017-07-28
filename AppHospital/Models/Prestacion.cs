using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Prestacion : Recurso
    {
        public String nombre { get; set; }
        public List<Cita> citas { get; set; }
        public int coste { get; set; }
    }
}