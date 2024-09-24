using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_estudiantes
{
    internal class Estudiante
    {
        public string Nombre;
        private int Edad;
        public double Promedio;
        Estudiante (string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

    public bool mayor()
    {
        return Edad >= 18;
    }

    public void info()
    {
        Console.WriteLine("Nombre: {Nombre}, Promedio: {Promedio}");
    }
}
}
