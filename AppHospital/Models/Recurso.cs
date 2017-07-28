using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppHospital.Models
{
    public class Recurso
    {
        public int identificador { get; set; }
        public int planta { get; set; }
        public bool ocupado { get; set; }

        public void OcuparRecurso()
        {
            ocupado = true;
        }
        public void DesocuparRecurso()
        {
            ocupado = false;
        }

        //No implementado todavía
        //public bool CambiarEstado(bool nuevoEstado)
        //{

        //    return nuevoEstado;
        //}
    }
}