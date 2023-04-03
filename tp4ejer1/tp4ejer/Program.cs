using System;
//Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario ingresa alguno de
//esos dos caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
//contrario, se deberá imprimir “INCORRECTO”.
namespace tp4ejer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s = 'S';
            char n = 'N';
            Console.WriteLine("Ingresa el caracter S y N:");
            s =char.Parse(Console.ReadLine());
            n=char.Parse(Console.ReadLine());
            if ((s == 'S') && (n == 'N'))
            {
                Console.Write("CORRECTO!");
            }
            else
            {
                Console.WriteLine("INCORRECTO!");
            }
            Console.ReadKey();
        }
    }
}
