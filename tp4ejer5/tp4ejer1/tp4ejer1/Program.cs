using System;
//- Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario ingresa alguno de
//esos dos caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
//contrario, se deberá imprimir “INCORRECTO”.
namespace tp4ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carct1, carct2;
            Console.WriteLine("Ingrese el caracter S");
            carct1=Console.ReadLine();
            Console.WriteLine("Ingrese el caracter N");
            carct2 = Console.ReadLine();
            if ((carct1 == "S")&&(carct2== "N"))
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
         
            }
            Console.ReadKey();
        }

    }
}
