using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Lenguajes
{
    class Punto1
    {
        public static void ejecutar()
        {
            int n = 3; //Variable que determina el número de participantes ejercicio obvia que son 20;
            //Descomentar estas líneas y comentar la siguiente para que el usuario elija el número de participantes
            /*
            do
            {
                Console.Write("Digitar el numero de participantes: ");
                if (!int.TryParse(Console.ReadLine(), out n) ||(n <= 0))numeroInvalido();
            } while (n <= 0); */

            String[] participantes = new String[n]; //Declaración de los vectores a usar
            String[] ids = new String[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] nota3 = new double[n];
            double[] notas = new double[n];

            pedirDatos(participantes, ids, nota1, nota2, nota3); //Función que pide el nombre, id y las 3 notas
            mostrarPuntajes(participantes, ids, nota1, nota2, nota3, notas); //Calcula y muestra todos los participantes y sus puntajes
            mostrarMayoresPuntajes(notas, ids);
            Console.Write("\nPresione INTRO para continuar");
            Console.ReadLine();
            Console.Clear();
        }//Punto 1 del taller
        static void pedirDatos(String[] nombres, String[] ids, double[] nota1, double[] nota2, double[] nota3)
        {
            double nota = 0;
            //bool esValida;
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingresar el nombre del participante {0}: ", (i + 1));
                nombres[i] = Console.ReadLine();
                Console.Write("Ingresar el id del participante {0}: ", (i + 1));
                ids[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    /* do
                     {
                         //Descomentar para pedir las notas al usuario
                         Console.Write("Ingresar el puntaje de la prueba {0} del participante {1}: ", (j + 1), (i + 1)); //Pide las 3 notas
                         esValida = double.TryParse(Console.ReadLine(), out nota); //No se determina un estandar de notas en el ejercicio, puede digitar cualquier número
                         if(!esValida) numeroInvalido();
                     } while (!esValida);*/
                    asignarNota(nota1, nota2, nota3, j, i, nota); //Asigna la nota digitada a un vector
                }
                Console.Clear();
            }
            Console.Clear();
        }
        static void mostrarPuntajes(String[] nombre, String[] id, double[] nota1, double[] nota2, double[] nota3, double[] nota)
        {
            //Esta función calcula y muestra los resultados de todos los participantes
            for (int i = 0; i < nota1.Length; i++)
            {
                nota[i] = ((nota1[i] * 0.3) + (nota2[i] * 0.4) + (nota3[i] * 0.3)); //Calculo de puntaje con respecto a los porcentajes
                Console.WriteLine("El puntaje del participante {0}, con id {1} fue: {2}", nombre[i], id[i], Math.Round(nota[i], 2)); //Muestra los resultados del participante
            }
        }
        static void mostrarMayoresPuntajes(double[] nota, String[] id) //Compara todas las posiciones con la nota máxima para ver si hay un "empate"
        {
            Console.WriteLine("\nIDs de el, o los participantes con el mayor puntaje:");
            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] == nota.Max()) Console.Write("{0} - ", id[i]); //Compara todas las posiciones con la nota máxima para ver si hay un "empate"
            }
        }
        static void asignarNota(double[] nota1, double[] nota2, double[] nota3, int j, int i, double nota)
        {
            /*Se instancia cuando el usuario digita una de las 3 notas, dependiendo de la posición en el ciclo que se está ejecutando la asigna
             a un vector*/
            Random rnd = new Random();
            switch (j)
            {
                case 0:
                    //nota1[i] = nota; //Asigna la nota digitada en caso de que se ingresen manualmente
                    nota1[i] = (rnd.NextDouble() * 5); //Notas aleatorias entre 0 y 5;
                    break;
                case 1:
                    //nota2[i] = nota;
                    nota2[i] = (rnd.NextDouble() * 5);
                    break;
                case 2:
                    //nota3[i] = nota;
                    nota3[i] = (rnd.NextDouble() * 5);
                    break;
            }
        }
    }
}