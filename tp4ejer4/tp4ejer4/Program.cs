using System;
//Realizar un programa que pida una frase o palabra y si la frase o palabra es de 4 caracteres de largo, el
//programa le concatenara un signo de exclamación al final, y si no es de 4 caracteres el programa le
//concatenara un signo de interrogación al final. El programa mostrará después la frase final.
namespace tp4ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Ingrese una frase o palabra de 4 caracteres: ");
            frase = Console.ReadLine();
            if (frase.Length == 4)
            {
                Console.WriteLine(frase + "!");
            }
            else
            {
                Console.WriteLine(frase + "?");
            }
            Console.ReadKey();
        }
    }
}
