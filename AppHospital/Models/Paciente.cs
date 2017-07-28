using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Paciente : Persona
    {
        public int altura { get; set; }
        public int identificador { get; set; }
        public int peso { get; set; }
        public int grupoSanguineo { get; set; }
        public List<Cita> listadoCitas { get; set; }
        public Cama cama { get; set; }
        public Medico medicoCabecera { get; set; }
    }
}