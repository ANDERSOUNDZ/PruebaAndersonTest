using Ejercicio__2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonasLista();
        }

        static double PersonasLista()
        {
            
            Persona persona = new Persona();
            if (persona.Edad >= 18)
            {
                 return Console.WriteLine( persona.Apellido + persona.Nombre + persona.Edad); 
            }
            else {
                return Console.WriteLine("Mujeres menores a -18");
            }
                        
        }
    }
}
