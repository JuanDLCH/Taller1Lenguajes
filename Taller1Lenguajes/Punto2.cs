using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Lenguajes
{
    class Punto2:Program
    {
        public static void ejecutar() //Punto 2 del Taller (Código 3620896 para cerrar votación)
        {
            int[] urna = new int[5]; //Paralelo a Departamentos
            //Vector paralelo a la urna, (La posición 0 de la urna es la cantidad de votos por el departamento en la posición 0 de este vector)
            string[] Departamentos = new string[] { "Antioquia", "Atlántico", "Cundinamarca", "Tolima", "Valle del Cauca" };
            votar(urna, Departamentos);
            mostrarMayoresVotos(urna, Departamentos);
            mostrarVotosPorCadaDep(urna, Departamentos);
            mostrarMenoresVotos(urna, Departamentos);
            Console.Write("\n\nPresione INTRO para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static void votar(int[] urna, String[] Departamentos)//Recibe el voto digitado por el usuario y lo asigna a la urna
        {
            int password = 3620896; //Contraseña para cerrar la votación
            int voto = 7;
            do
            {
                Console.WriteLine("Digitar\n'1' para votar por Antioquia;\n'2' para votar por Atlántico;\n'3' para votar por Cundinamarca;\n'4' para votar por Tolima;\n'5' para votar por Valle del Cauca");
                //Si no pudo convertir a entero probablemente ingresó una letra, esto previene el cierre de la aplicación después de eso
                if (!int.TryParse(Console.ReadLine(), out voto) || ((voto > 5 || voto < 1) && (voto != password)))
                {
                    numeroInvalido(); //Pide número de nuevo si ingresó uno inválido
                }
                else if (voto != password)
                {
                    urna[voto - 1]++; //Asignar el voto al vector "urna"
                }
                Console.Clear();
            } while (voto != password); //Si digita la contraseña no se vota más y se pasa a elegir al ganador
        }
        static void mostrarMayoresVotos(int[] urna, String[] Departamentos)
        {
            Console.WriteLine("Ganador(es):");
            for (int i = 0; i < urna.Length; i++)
            {
                if (urna[i] == urna.Max()) Console.Write("{0} - ", Departamentos[i]); //Muestra el, o los departamentos que tuvieron la mayor cantidad de votos
            }
        }
        static void mostrarVotosPorCadaDep(int[] urna, String[] depa)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < urna.Count(); i++) //Recorre el vector mostrando la cantidad de votos y el nombre correspondiente
            {
                Console.WriteLine("Votos por {0}: {1}", depa[i], urna[i]);
            }
        }
        static void mostrarMenoresVotos(int[] urna, String[] depa)
        {
            Console.WriteLine("\nDepartamento(s) con menor cantidad de votos: ");
            for (int i = 0; i < urna.Length; i++)
            {
                //Recorre el vector mostrando los departamentos que tienen el número menor de votos, por si hay 2 con la misma cantidad
                if (urna[i] == urna.Min()) Console.Write("{0} - ", depa[i]);
            }
        }
    }
}