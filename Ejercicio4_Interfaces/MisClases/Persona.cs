using Ejercicio4_Interfaces.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Interfaces.MisClases
{
    internal class Persona : IPersona
    {
        public string Nombre { get; }

        public int Edad { get; }



        public void DecirMiNombre(string per1)
        {
            Console.WriteLine("Mi nombre es ");
        }


        public void cumplirAños(int per1)
        {
            Console.WriteLine("Mi edad es");
        }

    }
}
