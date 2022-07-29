using System;

namespace Practica_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca su edad:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es {0} y tiene {1}", name, edad);
        }
    }
}
