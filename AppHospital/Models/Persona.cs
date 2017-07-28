using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Persona
    {
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String poblacion { get; set; }

        public int CalcularEdad()
        {
            //Pendiente de prueba -> return Convert.ToInt32(fechaNacimiento - DateTime.Today);
            return DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1; //Sacado de internet
        }
        public string NombreCompleto()
        {
            return nombre + " " + apellidos;
        }
    }
}