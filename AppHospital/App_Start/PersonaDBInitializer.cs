using AppHospital.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace AppHospital.App_Start
{
    public class PersonaDBInitializer : DropCreateDatabaseAlways<DataAccess.PersonaDBContext>
    {
        protected override void Seed(DataAccess.PersonaDBContext context)

        {

            var personas = new List<Persona>
            {
                new Persona { nombre = "Julio", apellidos = "Avellaneda Perez"},
                new Persona { nombre = "Juan", apellidos = "Ruiz del Río"},
                new Persona { nombre = "Roberto", apellidos = "Alvarado Ramiro"},
                new Persona { nombre = "Nicolas", apellidos = "Herrera Hervas"},
                new Persona { nombre = "Jorge", apellidos = "Ramirez Iriarte"},
                new Persona { nombre = "Nelson", apellidos = "Venegas Ortiz"}
            };

            personas.ForEach(c => context.Persona.Add(c));
            context.SaveChanges();

        }

    }
}