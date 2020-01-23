using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Lenguajes
{
    class Punto4:Program
    {
        public static void ejecutar() //Punto 4 del taller
        {
            int[,] usuarios = new int[30, 19]; //19 estaciones por 30 días del mes de Junio
            List<int> menosDe8K = new List<int>(); //Vector o lista donde guarda las estaciones que recibieron menos de 8k usuarios
            usuarios = llenarMatriz(usuarios);
            Console.WriteLine("\nLa estación {0} tuvo más usuarios durante el mes de Junio\n", masUsuarios(usuarios, menosDe8K));
            //mostrarEstacionesConMenosDe8k(menosDe8K); //El ejercicio pide almacenar en el vector, pero no pide mostrarlo
            mostrarDiasConMenosDe400(usuarios);
            Console.Write("\nPresione INTRO para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static int masUsuarios(int[,] matriz, List<int> less8k) //Compara y retorna la estación que más usuarios tuvo durante el mes
        {
            int masUsuarios = 0, sum = 0, referencia = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    sum += matriz[j, i]; //Suma para obtener el promedio
                }
                if (sum > referencia)
                {
                    referencia = sum; //Variable de referencia, almacena la suma de usuarios de la estación que por ahora tiene la mayor cantidad de usuarios
                    masUsuarios = i; //Asigna entonces la estación que actualmente figura con más usuarios hasta que otra tome su lugar
                }
                if (sum < 8000) less8k.Add(i + 1); //añade el item a la lista; +1 porque empieza desde 0, entonces, por ejemplo la estación 0 es en realidad la 1
                Console.WriteLine("Promedio {0}: {1}", (i + 1), (sum / 30)); //Muestra el promedio de la estacion
            }
            
            return (masUsuarios + 1); //+1 porque empieza desde 0, entonces, por ejemplo la estación 0 es en realidad la 1
        }
        static void mostrarEstacionesConMenosDe8k(List<int> lista) //Muestra el vector con la lista de estaciones que recibieron menos de 8K
        {
            Console.Write("Las estaciones que recibieron menos de 8000 personas fueron: ");
            foreach (int estacion in lista)
            {
                Console.Write("{0} - ", estacion);
            }
            Console.WriteLine("\n");
        }
        static void mostrarDiasConMenosDe400(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    if (matriz[j, i] < 400) Console.WriteLine("La estación {0} tuvo menos de 400 usuarios el día {1}", (i + 1), (j + 1));
                }

            }
        }
    }
}