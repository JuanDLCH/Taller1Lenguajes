using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Lenguajes
{
    class Program
    {
        static void Main(string[] args) //Juan Diego Londoño Chavarría - Lenguaje de programación I - Grupo 061
        {
            int f;
            bool esValido;
            do
            {
                ejecutar(seleccionarPunto());
                Console.Write("Práctica presentada por: Juan Diego Londoño Chavarría\nCurso: Lenguaje de programación I\nGrupo: 061\n\nIngrese un número para salir, una letra o espacio vacío para reiniciar: ");
                esValido = (int.TryParse(Console.ReadLine(), out f) || (f != 1 && f != 0));
                if (!esValido) Console.Clear();
            } while (!esValido); //Si ingresa un carácter no válido o 0, reinicia el programa, si ingresa 1, lo cierra
        }
        static void ejecutar(int punto)
        {
            Console.Clear();
            switch (punto)
            {
                case (1):
                    Punto1.ejecutar();
                    break;
                case (2):
                    Punto2.ejecutar();
                    break;
                case (3):
                    Punto3.ejecutar();
                    break;
                case (4):
                    Punto4.ejecutar();
                    break;
            }
        }
        static int seleccionarPunto()
        {
            int punto = 0;
            Console.Write("Los datos como las notas se generan aleatoriamente, hay espacios comentados en el código para habilitar el ingresar los datos manualmenten\n\nPresione INTRO para iniciar");
            Console.ReadLine();
            Console.Clear();
            do
            {
                Console.Write("El taller consta de 4 puntos, ingrese un número de 1 a 4 para elegir el que desea ejecutar y presione INTRO: ");
                if (!int.TryParse(Console.ReadLine(), out punto) || (punto < 1 || punto > 4)) numeroInvalido(); //Si hay un error de conversión a entero pide el número de nuevo
            } while (punto < 1 || punto > 4);
            return punto;
        }
        public static double[] llenar(double[] vector)
        {
            Random rnd = new Random();
            for(int i = 0; i < vector.Length; i++)
            {
                /*Console.Write("Ingresar el dato número {0}: ",(i+1)); //Descomentar para pedir datos manualmente
                vector[i] = double.Parse(Console.ReadLine());*/ 
                vector[i] = Math.Round((rnd.NextDouble() * 5),2);
            }
            return vector;
        } //Llenar el vector (Pidiendo datos o aleatoriamente)
        public static int[,] llenarMatriz(int[,] matriz)
        {
            //bool esValido;
            Random n = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    /* do
                     {
                         Console.Write("Digitar la cantidad de usuarios del día {0}, en la estación {1}: ", (i + 1), (j + 1));
                         esValido = int.TryParse(Console.ReadLine(), out matriz[i, j]) || matriz[i, j] < 0;
                         if (!esValido) numeroInvalido();
                     } while (!esValido);*/

                    matriz[i, j] = n.Next(0, 10000);
                }
            }
            return matriz;
        } //Llena la matriz seleccionada con numeros aleatorios
        public static void numeroInvalido() //Acción a realizar cuando se ingresa un número no válido
        {
            Console.Beep();
            Console.Write("\nIngrese un valor válido, presione INTRO para reintentar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}