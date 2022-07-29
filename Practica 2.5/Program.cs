using System;

namespace Practica_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            
            Console.WriteLine("La suma es igual a:{0}", suma);
        }
    }
}
