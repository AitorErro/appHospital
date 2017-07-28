using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace AppHospital.Models
{
    public class PersonaBDContexto : DBContext
    {
        public DBSet Persona { get; set; }

        protected override void OnModelCreating(DbModeBuilder modelbuilder)
        {
            base.OnModelCreating(ModuleBuilder);
        }
    }
}