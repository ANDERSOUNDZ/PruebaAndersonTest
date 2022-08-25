using Ejercicio__2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio__2.Data
{
    internal class DatosLista
    {
        public List<Persona> ListaPersona()
        {
            return new List<Persona> 
            {
                new Persona {Nombre="Patricia",Apellido="Fernandez",Edad=32},
                new Persona {Nombre="Beatriz",Apellido="Pinzon",Edad=16},
                new Persona {Nombre="Berta",Apellido="Contreras",Edad=25}
            };
        }
    }
}
