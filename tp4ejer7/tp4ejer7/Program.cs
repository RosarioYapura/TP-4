using System;
//Continuando el ejercicio anterior, ahora se pedirá una frase o palabra y se validará si la primera letra de
//la frase es igual a la última letra de la frase. Se deberá de imprimir un mensaje por pantalla que diga
//“CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”.
namespace tp4ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, letra1, letra2;
            Console.WriteLine("Ingresa una frase que empiece y termine con la misma letra");
            frase = Console.ReadLine();
            letra1 = frase.Substring(0, 1);
            letra2 = frase.Substring(frase.Length - 1, 1);
            if (letra1 == letra2)
            {
                Console.WriteLine("CORRECTO!");
            }
            else
            {
                Console.WriteLine("INCORRECTO!");
            }
            Console.ReadKey();
        }
    }
}
