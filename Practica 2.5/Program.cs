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
            var suma = num1 + num2;
            var resta = num1 - num2;
            var multiplicacion = num1 * num2;
            var division = num1 / num2;
            
            Console.WriteLine("La suma es igual a:{0}", suma);
            Console.WriteLine("La resta es igual a {0}", resta);
            Console.WriteLine("La multiplicacion es igual a {0}", multiplicacion);
            Console.WriteLine("La division es igual a {0}", division);
        }
    }
}
