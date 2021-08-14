using System;

namespace Estructura_FOR
{
    class Program
    {
        static void Main(string[] args)

        {
            //Programa que calcula el promedio de 3 numeros
            //Variables
            double n1 = 0.0;
            double n2 = 0.0;
            double n3 = 0.0;
            double Promedio = 0.0;
            String dato = "";

            Console.WriteLine("Dame un numero");
            dato = Console.ReadLine();
            n1 = Convert.ToDouble(dato);

            Console.WriteLine("Dame el siguiente numero");
            dato = Console.ReadLine();
            n2 = Convert.ToDouble(dato);

            Console.WriteLine("otro numero por favor");
            dato = Console.ReadLine();
            n3 = Convert.ToDouble(dato);

            Promedio = (n1 + n2 + n3) / 3.0;

            Console.WriteLine("El Promedio es {0}", Promedio);

            
        }
    }
}