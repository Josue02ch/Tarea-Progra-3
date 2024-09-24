using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_estudiantes
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            Console.WriteLine("Por favor, ingrese la cantidad de estudiantes a registrar: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Por favor, ahora ingrese los datos del estudiante {i + 1}");
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Promedio: ");
                double promedio = double.Parse(Console.ReadLine());

                Estudiante estudiante = new Estudiante(nombre,
                                                       edad, 
                                                       promedio);

                estudiantes.Add(estudiante);

            }

            Console.WriteLine("Los estudiantes cin promedio mayor o igual a 70");
            int index = 0;
            while (index < estudiantes.Count)
            {
                if (estudiantes[index].Promedio >= 70)
                {
                    estudiantes[index].info();

                    if (estudiantes[index].mayor())
                    {
                        Console.WriteLine("{estudiantes[i].Nombre} es mayor de edad");

                    }
                    else
                    {
                        Console.WriteLine("{estudiantes[i].Nombre} no es mayor de edad");
                    }
                }
                index++;
                Console.ReadKey();
            }
        }
    }
}
