using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_tarea_segundo_semestre
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bienvenida();
            operacionsuma();
            operacionresta();
            operacionmulti();
            operaciondivision();
        }
        static void bienvenida()
        {
            Console.WriteLine("Bienvenido a mi primer trabajo del segundo semestre");
            Console.WriteLine("Por favor ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre + " Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
        static void operacionsuma()
        {
            Console.WriteLine("Ingrese el primer valor para hacer una suma");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor para hacer una suma");
            int num2 = int.Parse(Console.ReadLine());
            int suma1 = num1 + num2;
            Console.WriteLine("La suma de los primeros valores es: " + suma1);
        }
        static void operacionresta()
        {
            Console.WriteLine("Ingrese el primer valor para hacer una resta");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor para hacer una resta");
            int num4 = int.Parse(Console.ReadLine());
            int resta1 = num3 - num4;
            Console.WriteLine("La suma de estos valores es: " + resta1);
        }
        static void operacionmulti()
        {
            Console.WriteLine("Ingrese el primer valor a múltiplicar");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor a múltiplicar");
            int num6 = int.Parse(Console.ReadLine());
            int multi1 = num5 * num6;
            Console.WriteLine("La multiplicación es igual a: " + multi1);
        }
        static void operaciondivision()
        {
            Console.WriteLine("Ingresa el primer valor a dividir");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valor a dividir");
            int num8 = int.Parse(Console.ReadLine());
            int division = num7 / num8;
            Console.WriteLine("La división es igual a: " + division);
            Console.WriteLine(":)");
            Console.ReadKey();
        }
    }
}
