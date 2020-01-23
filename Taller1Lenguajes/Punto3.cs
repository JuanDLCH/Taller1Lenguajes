using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Lenguajes
{
    class Punto3:Program
    {
        public static void ejecutar()  //Punto 3 del taller
        {
            int n = 35; //Variable que determina el número de estudiantes; el ejercicio obvia que son 35
                        /* bool esValido;
                         do
                         {
                             Console.Write("Cantidad de estudiantes en el curso: ");
                             esValido = int.TryParse(Console.ReadLine(), out n) || n < 0;
                             if(!esValido) numeroInvalido();
                         }while (!esValido);   */
            double[] notas = new double[n];
            notas = llenar(notas);
            mostrarPromedioYNotamenor(notas);
            Console.Write("\nPresione INTRO para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static void mostrarPromedioYNotamenor(double[] notas)
        {
            Console.WriteLine("El promedio de notas del grupo es: {0}", Math.Round(notas.Average(), 2)); //Muestra el promedio con 2 decimales
            Console.WriteLine("La menor nota del grupo fue: {0}", notas.Min()); //Muestra la menor nota
        }
    }
}