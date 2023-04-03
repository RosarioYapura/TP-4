using System;
//Realizar un programa que pida un número y determine si ese número es par o impar. Mostrar en pantalla
//un mensaje que indique si el número es par o impar. (para que un número sea par, se debe dividir entre dos
//y su resto debe ser igual a 0).
namespace tp4ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());
            if(num / 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
                {
                Console.WriteLine("El numero ingresado es impar");
            }
            Console.ReadKey();

        }
    }
}
